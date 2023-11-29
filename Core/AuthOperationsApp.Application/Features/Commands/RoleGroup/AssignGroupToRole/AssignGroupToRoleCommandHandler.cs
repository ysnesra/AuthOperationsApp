using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.DTOs.RoleGroup;
using AutoMapper;
using MediatR;


namespace AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignGroupToRole
{
    public class AssignGroupToRoleCommandHandler : IRequestHandler<AssignGroupToRoleCommandRequest, AssignGroupToRoleCommandResponse>
    {
        private readonly IRoleGroupService _roleGroupService;
        private readonly IMapper _mapper;      

        public AssignGroupToRoleCommandHandler(IRoleGroupService roleGroupService, IMapper mapper)
        {
            _roleGroupService = roleGroupService;
            _mapper = mapper;
         
        }

        public async Task<AssignGroupToRoleCommandResponse> Handle(AssignGroupToRoleCommandRequest request, CancellationToken cancellationToken)
        {
            //var res = await _roleGroupService.AssignGroupToRoleAsync(request.GroupId, request.RoleId);
            //var assignGroupToRoleInfoDto = _mapper.Map<AssignGroupToRoleInfoDto>(res);

            //return new AssignGroupToRoleCommandResponse(assignGroupToRoleInfoDto);
            return null;
        }
    }
}
