using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.DTOs.Group;
using AuthOperationsApp.Application.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

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
        public async Task<List<GroupListDto?>> GetAllGroupAsync()
        {
            var groups = await _groupReadRepository.GetAll().ToListAsync();

            var groupsDto = _mapper.Map<List<GroupListDto>>(groups);
            return groupsDto;
        }
    }
}
