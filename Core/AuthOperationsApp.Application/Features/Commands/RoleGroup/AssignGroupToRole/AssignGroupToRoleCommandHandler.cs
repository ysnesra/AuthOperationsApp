using AuthOperationsApp.Application.Abstractions.Services;
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
            //RoleId ajax ile gelecek
            var response = await _roleGroupService.AssignGroupToRoleAsync(request.GroupId, request.RoleId);
           

            return new AssignGroupToRoleCommandResponse(response);
        }
    }
}
