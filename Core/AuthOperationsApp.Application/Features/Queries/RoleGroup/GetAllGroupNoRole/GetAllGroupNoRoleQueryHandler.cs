using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AutoMapper;
using MediatR;


namespace AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupNoRole
{
    public class GetAllGroupNoRoleQueryHandler : IRequestHandler<GetAllGroupNoRoleQueryRequest, GetAllGroupNoRoleQueryResponse>
    {
        private readonly IRoleGroupService _roleGroupService;
        private readonly IMapper _mapper;

        public GetAllGroupNoRoleQueryHandler(IRoleGroupService roleGroupService, IMapper mapper)
        {
            _roleGroupService = roleGroupService;
            _mapper = mapper;
        }

        public async Task<GetAllGroupNoRoleQueryResponse> Handle(GetAllGroupNoRoleQueryRequest request, CancellationToken cancellationToken)
        {
            
            List<AllGroupNoRoleDto?> groupsNoRole = await _roleGroupService.GetGroupsNoRoleAsync(request.RoleId);

            AllGroupNoRoleInfoDto allGroupNoRoleInfoDto = new AllGroupNoRoleInfoDto();
            if (groupsNoRole is null)
            {
                allGroupNoRoleInfoDto.Success = false;
                allGroupNoRoleInfoDto.Message = "Groups without assigned roles not found.";
                allGroupNoRoleInfoDto.AllGroupNoRoleDto = [];
                return new GetAllGroupNoRoleQueryResponse(allGroupNoRoleInfoDto);

            }
            allGroupNoRoleInfoDto.Success = true;
            allGroupNoRoleInfoDto.Message = "Groups without assigned roles listed succesfully.";
            allGroupNoRoleInfoDto.AllGroupNoRoleDto = groupsNoRole;
            return new GetAllGroupNoRoleQueryResponse(allGroupNoRoleInfoDto);
        }
    }
}
