using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.UserGroup;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.User.GetAllUserByGroup
{
    public class GetAllUserByGroupQueryHandler : IRequestHandler<GetAllUserByGroupQueryRequest, GetAllUserByGroupQueryResponse>
    {
        private readonly IUserGroupService _userGroupService;
        private readonly IMapper _mapper;

        public GetAllUserByGroupQueryHandler(IUserGroupService userGroupService, IMapper mapper)
        {
            _userGroupService = userGroupService;
            _mapper = mapper;
        }

        public async Task<GetAllUserByGroupQueryResponse> Handle(GetAllUserByGroupQueryRequest request, CancellationToken cancellationToken)
        {
            List<UserByGroupDto?> groups = await _userGroupService.GetUsersByGroupIdAsync(request.GroupId);

            UserByGroupInfoDto userByRoleInfoDto = new UserByGroupInfoDto();
            if (groups is null)
            {
                userByRoleInfoDto.Success = false;
                userByRoleInfoDto.Message = Messages.GroupsBelongingRoleNotFound;
                userByRoleInfoDto.UserByGroupDto = [];
                return new GetAllUserByGroupQueryResponse(userByRoleInfoDto);

            }
            userByRoleInfoDto.Success = true;
            userByRoleInfoDto.Message = Messages.GroupsBelongingRoleSuccess;
            userByRoleInfoDto.UserByGroupDto = groups;
            return new GetAllUserByGroupQueryResponse(userByRoleInfoDto);
        }
    }
}
