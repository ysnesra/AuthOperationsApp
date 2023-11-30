using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetAllRoleByGroup
{
    public class GetAllRoleByGroupQueryHandler : IRequestHandler<GetAllRoleByGroupQueryRequest, GetAllRoleByGroupQueryResponse>
    {
        private readonly IRoleGroupService _roleGroupService;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetAllRoleByGroupQueryHandler(IRoleGroupService roleGroupService, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _roleGroupService = roleGroupService;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<GetAllRoleByGroupQueryResponse> Handle(GetAllRoleByGroupQueryRequest request, CancellationToken cancellationToken)
        {
            List<RoleByGroupDto?> groups = await _roleGroupService.GetRolesByGroupIdAsync(request.GroupId);

            RoleByGroupInfoDto groupByRoleInfoDto = new RoleByGroupInfoDto();
            if (groups is null)
            {
                groupByRoleInfoDto.Success = false;
                groupByRoleInfoDto.Message = Messages.GroupsBelongingRoleNotFound;
                groupByRoleInfoDto.RoleByGroupDto = [];
                return new GetAllRoleByGroupQueryResponse(groupByRoleInfoDto);

            }
            groupByRoleInfoDto.Success = true;
            groupByRoleInfoDto.Message = Messages.GroupsBelongingRoleSuccess;
            groupByRoleInfoDto.RoleByGroupDto = groups;
            return new GetAllRoleByGroupQueryResponse(groupByRoleInfoDto);
        }
    }
}

