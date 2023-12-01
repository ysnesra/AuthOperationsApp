using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Application.DTOs.User;
using AuthOperationsApp.Application.Features.Commands.Role.UpdateRole;
using AuthOperationsApp.Application.Features.Commands.User.UpdateUser;
using AuthOperationsApp.Application.Features.Queries.User.GetAllUser;
using AuthOperationsApp.Infrastructure.Base;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthOperationsApp.WEB.Controllers
{
    public class UserController : BaseController
    {
        public UserController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> GetAllUsers()
        {
            GetAllUserQueryRequest request = new GetAllUserQueryRequest();

            GetAllUserQueryResponse response = await Mediator.Send(request);

            if (!response.UserListInfoDto.Success)
            {
                return Json(new { error = response.UserListInfoDto.Message });
            }
            return Json(response.UserListInfoDto.UserListDto);
        }

        [HttpPost]
        public async Task<JsonResult> UpdateUser([FromBody] UpdateUserRequestDto userRequestDto)
        {
            UpdateUserCommandRequest request = new UpdateUserCommandRequest();
            request.Id = Guid.Parse(userRequestDto.Id);
            request.FullName = userRequestDto.FullName;

            UpdateUserCommandResponse response = await Mediator.Send(request);
            if (!response.UpdateUserInfoDto.Success)
            {
                return Json(response.UpdateUserInfoDto.Message);
            }
            return Json(response);
        }
    }
}
