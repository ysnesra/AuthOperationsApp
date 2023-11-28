using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.Role;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetAllRole
{
    public class GetAllRoleQueryHandler : IRequestHandler<GetAllRoleQueryRequest, GetAllRoleQueryResponse>
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public GetAllRoleQueryHandler(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        public async Task<GetAllRoleQueryResponse> Handle(GetAllRoleQueryRequest request, CancellationToken cancellationToken)
        {
            List<RoleListDto?> roles = await _roleService.GetAllRoleAsync();

            RoleListInfoDto roleListInfoDto = new RoleListInfoDto();
            if (roles is null)
            {
                roleListInfoDto.Success = false;
                roleListInfoDto.Message = Messages.RolesListedFailed;                
                return new GetAllRoleQueryResponse(roleListInfoDto);

            }
            roleListInfoDto.Success = true;
            roleListInfoDto.Message = Messages.RolesListed; 
            roleListInfoDto.RoleListDto = roles;
            return new GetAllRoleQueryResponse(roleListInfoDto);
        }
    }
}
