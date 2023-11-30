
using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.Group;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.Group.GetAllGroup
{
    public class GetAllGroupQueryHandler : IRequestHandler<GetAllGroupQueryRequest, GetAllGroupQueryResponse>
    {
        private readonly IGroupService _groupService;
        private readonly IMapper _mapper;

        public GetAllGroupQueryHandler(IGroupService groupService, IMapper mapper)
        {
            _groupService = groupService;
            _mapper = mapper;
        }

        public async Task<GetAllGroupQueryResponse> Handle(GetAllGroupQueryRequest request, CancellationToken cancellationToken)
        {
            List<GroupListDto?> roles = await _groupService.GetAllGroupAsync();

            GroupListInfoDto groupListInfoDto = new GroupListInfoDto();
            if (roles is null)
            {
                groupListInfoDto.Success = false;
                groupListInfoDto.Message = Messages.GroupListedFailed;
                return new GetAllGroupQueryResponse(groupListInfoDto);

            }
            groupListInfoDto.Success = true;
            groupListInfoDto.Message = Messages.GroupListed;
            groupListInfoDto.GroupListDto = roles;
            return new GetAllGroupQueryResponse(groupListInfoDto);
        }
    }
}
