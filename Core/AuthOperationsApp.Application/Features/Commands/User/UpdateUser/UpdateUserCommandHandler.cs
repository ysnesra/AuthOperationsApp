
using AuthOperationsApp.Application.Abstractions.Services;
using MediatR;

namespace AuthOperationsApp.Application.Features.Commands.User.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
    {
        private readonly IUserService _userService;

        public UpdateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var updateUser = await _userService.UpdateAsync(request, cancellationToken);
            return new UpdateUserCommandResponse(updateUser);
        }
    }
}
