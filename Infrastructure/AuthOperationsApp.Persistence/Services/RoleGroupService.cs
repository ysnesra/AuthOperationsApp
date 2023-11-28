

using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Repositories;
using AutoMapper;

namespace AuthOperationsApp.Persistence.Services
{
    public class RoleGroupService : IRoleGroupService
    {
        private readonly IMapper _mapper;
        private readonly IRoleGroupReadRepository _roleGroupReadRepository;
        private readonly IRoleGroupWriteRepository _roleGroupWriteRepository;

        public RoleGroupService(IMapper mapper, IRoleGroupReadRepository roleGroupReadRepository, IRoleGroupWriteRepository roleGroupWriteRepository)
        {
            _mapper = mapper;
            _roleGroupReadRepository = roleGroupReadRepository;
            _roleGroupWriteRepository = roleGroupWriteRepository;
        }
    }
}
