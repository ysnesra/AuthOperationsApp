using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Application.Repositories;
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
    }
}
