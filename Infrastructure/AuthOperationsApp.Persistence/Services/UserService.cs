using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.Constants;
using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Application.DTOs.User;
using AuthOperationsApp.Application.Features.Commands.User.UpdateUser;
using AuthOperationsApp.Application.Repositories;
using AuthOperationsApp.Domain.Entities;
using AuthOperationsApp.Persistence.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AuthOperationsApp.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;

        public UserService(IMapper mapper, IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository)
        {
            _mapper = mapper;
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
        }
        
            public async Task<List<UserListDto?>> GetAllUserAsync()
        {
            var users = await _userReadRepository.GetAll().ToListAsync();

            var usersDto = _mapper.Map<List<UserListDto>>(users);
            return usersDto;
        }

        public async Task<UserByIdDto> GetUserByIdAsync(Guid id, bool tracking = true)
        {
            var userDetail = await _userReadRepository.GetByIdAsync(id);

            var userDetailDto = _mapper.Map<UserByIdDto>(userDetail);
            return userDetailDto;
        }

        public async Task<UpdateUserInfoDto> UpdateAsync(UpdateUserCommandRequest request,
          CancellationToken cancellationToken, bool tracking = false)
        {
            var userDto = await GetUserByIdAsync(request.Id);
            if (userDto is null)
                return new UpdateUserInfoDto
                {
                    Success = false,
                    Message = Messages.UserNotExist,
                };

            userDto.FullName = request.FullName;

            var userDb = _mapper.Map<User>(userDto);

            var userResponse = _userWriteRepository.Update(userDb);

            if (!userResponse)
            {
                return new UpdateUserInfoDto
                {
                    Success = false,
                    Message = Messages.UpdateUserFailed,
                };
            }
            UpdateUserDto userMapped = new UpdateUserDto()
            {
                Id = userDb.Id,
                FullName=userDto.FullName,
            };
            UpdateUserInfoDto userMappedInfoDto = new UpdateUserInfoDto
            {
                Success = false,
                Message = Messages.UpdateUserFailed,
                UpdateUserDto = userMapped
        };

            return userMappedInfoDto;
        }
    }
}
