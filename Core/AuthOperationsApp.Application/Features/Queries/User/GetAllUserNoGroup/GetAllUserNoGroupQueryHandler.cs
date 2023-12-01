

using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.UserGroup;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.User.GetAllUserNoGroup
{
    public class GetAllUserNoGroupQueryHandler : IRequestHandler<GetAllUserNoGroupQueryRequest, GetAllUserNoGroupQueryResponse>
    {
        private readonly IUserGroupService _userGroupService;
        private readonly IMapper _mapper;

        public GetAllUserNoGroupQueryHandler(IUserGroupService userGroupService, IMapper mapper)
        {
            _userGroupService = userGroupService;
            _mapper = mapper;
        }

        public async Task<GetAllUserNoGroupQueryResponse> Handle(GetAllUserNoGroupQueryRequest request, CancellationToken cancellationToken)
        {
            List<AllUserNoGroupDto?> usersNoGroup = await _userGroupService.GetUserNoGroupAsync(request.GroupId);

            AllUserNoGroupInfoDto allUserNoGroupInfoDto = new AllUserNoGroupInfoDto();
            if (usersNoGroup is null)
            {
                allUserNoGroupInfoDto.Success = false;
                allUserNoGroupInfoDto.Message = Messages.GroupsWithoutAssignRolesNotFound;
                allUserNoGroupInfoDto.AllUserNoGroupDto = [];
                return new GetAllUserNoGroupQueryResponse(allUserNoGroupInfoDto);

            }
            allUserNoGroupInfoDto.Success = true;
            allUserNoGroupInfoDto.Message = Messages.GroupsWithoutAssignRolesSuccess;
            allUserNoGroupInfoDto.AllUserNoGroupDto = usersNoGroup;
            return new GetAllUserNoGroupQueryResponse(allUserNoGroupInfoDto);
        }
    }
}
