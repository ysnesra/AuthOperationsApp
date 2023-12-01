using AuthOperationsApp.Application.Abstractions.Services;
using AuthOperationsApp.Application.DTOs.User;
using AuthOperationsApp.Application.Repositories;
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
    }
}
