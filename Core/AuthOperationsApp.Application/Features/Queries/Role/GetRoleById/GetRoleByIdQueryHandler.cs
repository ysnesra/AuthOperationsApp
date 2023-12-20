using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Application.DTOs.User;
using AuthOperationsApp.Application.Features.Queries.User.GetAllUser;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.Role.GetRoleById
{
    public class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQueryRequest, GetRoleByIdQueryResponse>
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public GetRoleByIdQueryHandler(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        public async Task<GetRoleByIdQueryResponse> Handle(GetRoleByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var role = await _roleService.GetRoleByIdAsync (request.Id);
            
            RoleByIdInfoDto roleByIdInfoDto = new RoleByIdInfoDto();
            if(role is null)
            {
                roleByIdInfoDto.Success = false;
                roleByIdInfoDto.Message = Messages.RoleNotExist;
                return new GetRoleByIdQueryResponse(roleByIdInfoDto);
            }
            roleByIdInfoDto.Success = true;
            roleByIdInfoDto.Message = Messages.UserListed;
            roleByIdInfoDto.RoleByIdDto = role;
            return new GetRoleByIdQueryResponse(roleByIdInfoDto);

        }
    }
}
