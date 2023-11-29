using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AuthOperationsApp.Application.Repositories;
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
    }
}
