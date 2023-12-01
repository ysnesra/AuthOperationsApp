

using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.User;
using AutoMapper;
using MediatR;

namespace AuthOperationsApp.Application.Features.Queries.User.GetAllUser
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public GetAllUserQueryHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            List<UserListDto?> roles = await _userService.GetAllUserAsync();

            UserListInfoDto userListInfoDto = new UserListInfoDto();
            if (roles is null)
            {
                userListInfoDto.Success = false;
                userListInfoDto.Message = Messages.UserListedFailed;
                return new GetAllUserQueryResponse(userListInfoDto);

            }
            userListInfoDto.Success = true;
            userListInfoDto.Message = Messages.UserListed;
            userListInfoDto.UserListDto = roles;
            return new GetAllUserQueryResponse(userListInfoDto);
        }
    }
}
