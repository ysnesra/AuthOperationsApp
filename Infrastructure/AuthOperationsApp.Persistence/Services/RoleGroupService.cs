﻿using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace AuthOperationsApp.Persistence.Services
{
    public class RoleGroupService : IRoleGroupService
    {
        private readonly IMapper _mapper;
        private readonly IRoleGroupReadRepository _roleGroupReadRepository;
        private readonly IGroupReadRepository _groupReadRepository;
        private readonly IRoleGroupWriteRepository _roleGroupWriteRepository;

        public RoleGroupService(IMapper mapper, IRoleGroupReadRepository roleGroupReadRepository, IRoleGroupWriteRepository roleGroupWriteRepository, IGroupReadRepository groupReadRepository)
        {
            _mapper = mapper;
            _roleGroupReadRepository = roleGroupReadRepository;
            _roleGroupWriteRepository = roleGroupWriteRepository;
            _groupReadRepository = groupReadRepository;
        }

        public async Task<List<GroupByRoleDto?>> GetGroupsByRoleIdAsync(Guid roleId, bool tracking = false)
        {
            var groupIds = await _roleGroupReadRepository.GetWhere(x => x.RoleId == roleId)
                           .Select(x => x.GroupId).ToListAsync();
            var groupInfos = await _groupReadRepository.GetWhere(g => groupIds.Contains(g.Id), tracking).ToListAsync();

            var groupsDto = _mapper.Map<List<GroupByRoleDto>>(groupInfos);
            return groupsDto;
        }

        //Role atanmayan Gruplar
        public async Task<List<AllGroupNoRoleDto?>> GetGroupsNoRoleAsync(Guid roleId)
        {
            var groupsInRole = await _roleGroupReadRepository.GetWhere(x => x.RoleId == roleId).ToListAsync();
            var groupsNotInRole = await _groupReadRepository.GetAllDetailAsync(group => groupsInRole.Any(rg => rg.GroupId == group.Id));

            var groupsDto = _mapper.Map<List<AllGroupNoRoleDto>>(groupsNotInRole);
            return groupsDto;
        }

        //Role grup atama

        public async Task<AssignGroupToRoleInfoDto> AssignGroupToRoleAsync(Guid groupId, Guid roleId)
        {
            var existingGroup = await _groupReadRepository.GetByIdAsync(groupId);

            if (existingGroup is null)
            {
                return new AssignGroupToRoleInfoDto
                {
                    Success = false,
                    Message = $"Group with ID {groupId} does not exist in the system."
                };
            }

            var isRoleGroupAssigned = await _roleGroupReadRepository.GetWhere(x => x.GroupId == groupId && x.RoleId == roleId).AnyAsync();
            if (isRoleGroupAssigned)
            {
                return new AssignGroupToRoleInfoDto
                {
                    Success = false,
                    Message = $"Role has already been assigned to Group with ID {groupId}."
                };
            }

            var roleGroup = new RoleGroup
            {
                Id = Guid.NewGuid(),
                GroupId = groupId,
                RoleId = roleId
            };

            await _roleGroupWriteRepository.AddAsync(roleGroup);

            var mappedRoleGroup = _mapper.Map<AssignGroupToRoleDto>(roleGroup);

            return new AssignGroupToRoleInfoDto
            {
                Success = true,
                Message = "Group assigned to role successfully.",
                AssignGroupToRoleDto = mappedRoleGroup
            };
        }


        //Roleden grup kaldırma 
        public async Task<UnassignGroupToRoleInfoDto> UnassignGroupToRoleAsync(Guid groupId, Guid roleId)
        {
            var isRoleGroupAssigned = await _roleGroupReadRepository.GetWhere(x => x.GroupId == groupId && x.RoleId == roleId).FirstOrDefaultAsync();
            if (isRoleGroupAssigned is null)
            {
                return new UnassignGroupToRoleInfoDto
                {
                    Success = false,
                    Message = $"Role doesn't exist in Group with ID {groupId}."
                };
            }
   
            await _roleGroupWriteRepository.RemoveAsync(isRoleGroupAssigned.Id);

            var mappedRoleGroup = _mapper.Map<UnassignGroupToRoleDto>(isRoleGroupAssigned);

            return new UnassignGroupToRoleInfoDto
            {
                Success = true,
                Message = "Group unassigned to role successfully.",
                UnassignGroupToRoleDto = mappedRoleGroup
            };
        }
    }
}


