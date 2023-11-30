using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetAllRoleNoGroup
{
    public class GetAllRoleNoGroupQueryHandler : IRequestHandler<GetAllRoleNoGroupQueryRequest, GetAllRoleNoGroupQueryResponse>
    {
        private readonly IRoleGroupService _roleGroupService;
        private readonly IMapper _mapper;

        public GetAllRoleNoGroupQueryHandler(IRoleGroupService roleGroupService, IMapper mapper)
        {
            _roleGroupService = roleGroupService;
            _mapper = mapper;
        }

        public async Task<GetAllRoleNoGroupQueryResponse> Handle(GetAllRoleNoGroupQueryRequest request, CancellationToken cancellationToken)
        {
            List<AllRoleNoGroupDto?> rolesNoGroup = await _roleGroupService.GetRolesNoGroupAsync(request.GroupId);

            AllRoleNoGroupInfoDto allRoleNoGroupInfoDto = new AllRoleNoGroupInfoDto();
            if (rolesNoGroup is null)
            {
                allRoleNoGroupInfoDto.Success = false;
                allRoleNoGroupInfoDto.Message = Messages.GroupsWithoutAssignRolesNotFound;
                allRoleNoGroupInfoDto.AllRoleNoGroupDto = [];
                return new GetAllRoleNoGroupQueryResponse(allRoleNoGroupInfoDto);

            }
            allRoleNoGroupInfoDto.Success = true;
            allRoleNoGroupInfoDto.Message = Messages.GroupsWithoutAssignRolesSuccess;
            allRoleNoGroupInfoDto.AllRoleNoGroupDto = rolesNoGroup;
            return new GetAllRoleNoGroupQueryResponse(allRoleNoGroupInfoDto);
        }
    }
}
