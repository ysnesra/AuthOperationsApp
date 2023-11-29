using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Application.Features.Commands.Role.UpdateRole;
using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace AuthOperationsApp.Persistence.Services
{
    public class RoleService : IRoleService
    {
        private readonly IMapper _mapper;
        private readonly IRoleReadRepository _roleReadRepository;
        private readonly IRoleWriteRepository _roleWriteRepository;

        public RoleService(IMapper mapper, IRoleReadRepository roleReadRepository, IRoleWriteRepository roleWriteRepository)
        {
            _mapper = mapper;
            _roleReadRepository = roleReadRepository;
            _roleWriteRepository = roleWriteRepository;
        }

        public async Task<List<RoleListDto?>> GetAllRoleAsync()
        {
            var roles = await _roleReadRepository.GetAll().ToListAsync();

            var rolesDto = _mapper.Map<List<RoleListDto>>(roles);
            return rolesDto;
        }
        public async Task<RoleByIdInfoDto> GetRoleByIdAsync(Guid id, bool tracking = true)
        {
            var roleDetail = await _roleReadRepository.GetByIdAsync(id);
            if (roleDetail is null)
                return new RoleByIdInfoDto
                {
                    Success = false,
                    Message = $"Role doesn't exist."
                };
            var roleDetailDto = _mapper.Map<RoleByIdInfoDto>(roleDetail);
            return roleDetailDto;
        }


        public async Task<UpdateRoleInfoDto> UpdateAsync(UpdateRoleCommandRequest request,
           CancellationToken cancellationToken, bool tracking = false)
        {
            var roleDto = await GetRoleByIdAsync(request.Id, true);           
            var updateRoleInfoDto = _mapper.Map<UpdateRoleInfoDto>(roleDto);

            updateRoleInfoDto.UpdateRoleDto.Name = request.Name;

            var roleDb = _mapper.Map<Role>(updateRoleInfoDto.UpdateRoleDto.Name);
            var roleResponse = _roleWriteRepository.Update(roleDb);
          
            if (!roleResponse)
            {
                return new UpdateRoleInfoDto
                {
                    Success = false,
                    Message = $"Failed to update role."
                };
            }
            var roleMapped = _mapper.Map<UpdateRoleInfoDto>(roleDb);
            return roleMapped;
        }

    }
}
