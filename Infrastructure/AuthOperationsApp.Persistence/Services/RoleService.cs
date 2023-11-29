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
        public async Task<RoleByIdDto> GetRoleByIdAsync(Guid id, bool tracking = true)
        {
            var roleDetail = await _roleReadRepository.GetByIdAsync(id);
          
            var roleDetailDto = _mapper.Map<RoleByIdDto>(roleDetail);
            return roleDetailDto;
        }


        public async Task<UpdateRoleInfoDto> UpdateAsync(UpdateRoleCommandRequest request,
           CancellationToken cancellationToken, bool tracking = false)
        {
            var roleDto = await GetRoleByIdAsync(request.Id);
            if (roleDto is null)
                return new UpdateRoleInfoDto
                {
                    Success = false,
                    Message = $"Role doesn't exist."
                };
          
    

            roleDto.Name =request.Name;
  
            var roleDb = _mapper.Map<Role>(roleDto);

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
