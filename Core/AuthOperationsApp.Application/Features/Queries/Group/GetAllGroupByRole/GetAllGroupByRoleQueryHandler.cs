
using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;


namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole
{
    public class GetAllGroupByRoleQueryHandler : IRequestHandler<GetAllGroupByRoleQueryRequest, GetAllGroupByUserQueryResponse>
    {
        private readonly IRoleGroupService _roleGroupService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetAllGroupByRoleQueryHandler(IRoleGroupService roleGroupService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _roleGroupService = roleGroupService;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<GetAllGroupByUserQueryResponse> Handle(GetAllGroupByRoleQueryRequest request, CancellationToken cancellationToken)
        {
            List<GroupByRoleDto?> groups = await _roleGroupService.GetGroupsByRoleIdAsync(request.RoleId);

            GroupByRoleInfoDto groupByRoleInfoDto = new GroupByRoleInfoDto();
            if (groups is null)
            {
                groupByRoleInfoDto.Success = false;
                groupByRoleInfoDto.Message = Messages.GroupsBelongingRoleNotFound;
                groupByRoleInfoDto.GroupByRoleDto= [];
                return new GetAllGroupByUserQueryResponse(groupByRoleInfoDto);

            }
            groupByRoleInfoDto.Success = true;
            groupByRoleInfoDto.Message = Messages.GroupsBelongingRoleSuccess;
            groupByRoleInfoDto.GroupByRoleDto = groups;
            return new GetAllGroupByUserQueryResponse(groupByRoleInfoDto);
        }
    }
}
