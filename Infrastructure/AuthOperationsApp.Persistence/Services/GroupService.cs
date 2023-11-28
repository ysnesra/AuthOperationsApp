
using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Repositories;
using AutoMapper;

namespace AuthOperationsApp.Persistence.Services
{
    public class GroupService : IGroupService
    {
        private readonly IMapper _mapper;
        private readonly IGroupReadRepository _groupReadRepository;
        private readonly IGroupWriteRepository _groupWriteRepository;

        public GroupService(IMapper mapper, IGroupReadRepository groupReadRepository, IGroupWriteRepository groupWriteRepository)
        {
            _mapper = mapper;
            _groupReadRepository = groupReadRepository;
            _groupWriteRepository = groupWriteRepository;
        }
    }
}
