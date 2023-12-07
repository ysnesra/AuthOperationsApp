using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.UserGroup;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.Group.GetAllGroupByUser
{
    public class GetAllGroupByUserQueryHandler : IRequestHandler<GetAllGroupByUserQueryRequest, GetAllGroupByUserQueryResponse>
    {
        private readonly IUserGroupService _userGroupService;
        private readonly IMapper _mapper;

        public GetAllGroupByUserQueryHandler(IUserGroupService userGroupService, IMapper mapper)
        {
            _userGroupService = userGroupService;
            _mapper = mapper;
        }

        public async Task<GetAllGroupByUserQueryResponse> Handle(GetAllGroupByUserQueryRequest request, CancellationToken cancellationToken)
        {

            List<GroupByUserDto> groups = await _userGroupService.GetGroupsByUserIdAsync(request.UserId);

            GroupByUserInfoDto groupByUserInfoDto = new GroupByUserInfoDto();
            if (groups is null)
            {
                groupByUserInfoDto.Success = false;
                groupByUserInfoDto.Message = Messages.GroupsBelongingUserNotFound;
                groupByUserInfoDto.GroupByUserDto = [];
                return new GetAllGroupByUserQueryResponse(groupByUserInfoDto);

            }
            groupByUserInfoDto.Success = true;
            groupByUserInfoDto.Message = Messages.GroupsBelongingUserSuccess;
            groupByUserInfoDto.GroupByUserDto = groups;
            return new GetAllGroupByUserQueryResponse(groupByUserInfoDto);
        }
    }
}
