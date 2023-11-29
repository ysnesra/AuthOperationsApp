
using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;


namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole
{
    public class GetAllGroupByRoleQueryHandler : IRequestHandler<GetAllGroupByRoleQueryRequest, GetAllGroupByRoleQueryResponse>
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

        public async Task<GetAllGroupByRoleQueryResponse> Handle(GetAllGroupByRoleQueryRequest request, CancellationToken cancellationToken)
        {
            List<GroupByRoleDto?> groups = await _roleGroupService.GetGroupsByRoleIdAsync(request.RoleId);

            GroupByRoleInfoDto groupByRoleInfoDto = new GroupByRoleInfoDto();
            if (groups is null)
            {
                groupByRoleInfoDto.Success = false;
                groupByRoleInfoDto.Message = "Lessons belongig student not found.";
                groupByRoleInfoDto.GroupByRoleDto= [];
                return new GetAllGroupByRoleQueryResponse(groupByRoleInfoDto);

            }
            groupByRoleInfoDto.Success = true;
            groupByRoleInfoDto.Message = "Lessons belongig student listed succesfully.";
            groupByRoleInfoDto.GroupByRoleDto = groups;
            return new GetAllGroupByRoleQueryResponse(groupByRoleInfoDto);
        }
    }
}
