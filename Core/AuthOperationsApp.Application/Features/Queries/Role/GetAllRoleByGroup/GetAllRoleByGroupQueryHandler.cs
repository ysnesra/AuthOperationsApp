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

            RoleByGroupInfoDto roleByGroupInfoDto = new RoleByGroupInfoDto();
            if (groups is null)
            {
                roleByGroupInfoDto.Success = false;
                roleByGroupInfoDto.Message = Messages.GroupsBelongingRoleNotFound;
                roleByGroupInfoDto.RoleByGroupDto = [];
                return new GetAllRoleByGroupQueryResponse(roleByGroupInfoDto);

            }
            roleByGroupInfoDto.Success = true;
            roleByGroupInfoDto.Message = Messages.GroupsBelongingRoleSuccess;
            roleByGroupInfoDto.RoleByGroupDto = groups;
            return new GetAllRoleByGroupQueryResponse(roleByGroupInfoDto);
        }
    }
}

