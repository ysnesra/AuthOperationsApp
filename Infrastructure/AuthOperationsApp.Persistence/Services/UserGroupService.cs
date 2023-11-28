using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Repositories;
using AutoMapper;

namespace AuthOperationsApp.Persistence.Services
{
    public class UserGroupService : IUserGroupService
    {
        private readonly IMapper _mapper;
        private readonly IUserGroupReadRepository _userGroupReadRepository;
        private readonly IUserGroupWriteRepository _userGroupWriteRepository;

        public UserGroupService(IMapper mapper, IUserGroupReadRepository userGroupReadRepository, IUserGroupWriteRepository userGroupWriteRepository)
        {
            _mapper = mapper;
            _userGroupReadRepository = userGroupReadRepository;
            _userGroupWriteRepository = userGroupWriteRepository;
        }
    }
}
