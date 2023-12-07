
using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.UserGroup;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.Group.GetAllGroupNoUser
{
    public class GetAllGroupNoUserQueryHandler : IRequestHandler<GetAllGroupNoUserQueryRequest, GetAllGroupNoUserQueryResponse>
    {
        private readonly IUserGroupService _userGroupService;
        private readonly IMapper _mapper;

        public GetAllGroupNoUserQueryHandler(IUserGroupService userGroupService, IMapper mapper)
        {
            _userGroupService = userGroupService;
            _mapper = mapper;
        }

        public async Task<GetAllGroupNoUserQueryResponse> Handle(GetAllGroupNoUserQueryRequest request, CancellationToken cancellationToken)
        {
            List<AllGroupNoUserDto> groupsNoRole = await _userGroupService.GetGroupsNoUserAsync(request.UserId);

            AllGroupNoUserInfoDto allGroupNoUserInfoDto = new AllGroupNoUserInfoDto();
            if (groupsNoRole is null)
            {
                allGroupNoUserInfoDto.Success = false;
                allGroupNoUserInfoDto.Message = Messages.GroupsWithoutAssignUsersNotFound;
                allGroupNoUserInfoDto.AllGroupNoUserDto = [];
                return new GetAllGroupNoUserQueryResponse(allGroupNoUserInfoDto);

            }
            allGroupNoUserInfoDto.Success = true;
            allGroupNoUserInfoDto.Message = Messages.GroupsWithoutAssignUsersSuccess;
            allGroupNoUserInfoDto.AllGroupNoUserDto = groupsNoRole;
            return new GetAllGroupNoUserQueryResponse(allGroupNoUserInfoDto);
        }
    }
}
