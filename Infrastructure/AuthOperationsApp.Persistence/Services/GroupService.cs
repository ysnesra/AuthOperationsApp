using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.Group;
using AuthOperationsApp.Application.Features.Commands.Group.UpdateGroup;
using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
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
        public async Task<GroupByIdDto> GetGroupByIdAsync(Guid id, bool tracking = true)
        {
            var groupDetail = await _groupReadRepository.GetByIdAsync(id);

            var groupDetailDto = _mapper.Map<GroupByIdDto>(groupDetail);
            return groupDetailDto;
        }
        public async Task<UpdateGroupInfoDto> UpdateAsync(UpdateGroupCommandRequest request,
          CancellationToken cancellationToken, bool tracking = false)
        {
            var groupDto = await GetGroupByIdAsync(request.Id);
            if (groupDto is null)
                return new UpdateGroupInfoDto
                {
                    Success = false,
                    Message = Messages.GroupNotExist,
                };

            groupDto.Name = request.Name;

            var groupDb = _mapper.Map<Group>(groupDto);

            var groupResponse = _groupWriteRepository.Update(groupDb);

            if (!groupResponse)
            {
                return new UpdateGroupInfoDto
                {
                    Success = false,
                    Message = Messages.UpdateGroupFailed,
                };
            }
            var groupMapped = _mapper.Map<UpdateGroupInfoDto>(groupDb);
            return groupMapped;
        }

    }
}
