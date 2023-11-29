using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Application.Features.Commands.Role.UpdateRole;
using AuthOperationsApp.Application.Features.Queries.Role.GetAllRole;
using AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole;
using AuthOperationsApp.Infrastructure.Base;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthOperationsApp.WEB.Controllers
{
    [Authorize]
    public class RoleController : BaseController
    {
        public RoleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AllRoles()
        {
           
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<JsonResult> GetAllRoles()
        {
            GetAllRoleQueryRequest request= new GetAllRoleQueryRequest();
            
            GetAllRoleQueryResponse response = await Mediator.Send(request);

            if (!response.RoleListInfoDtos.Success)
            {
                return Json(new { error = response.RoleListInfoDtos.Message });
            }
            return Json(response.RoleListInfoDtos.RoleListDto);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<JsonResult> UpdateRole([FromBody] UpdateRoleRequestDto roleRequestDto )
        {
            UpdateRoleCommandRequest request = new UpdateRoleCommandRequest();
            request.Id = Guid.Parse(roleRequestDto.Id);
            request.Name = roleRequestDto.Name;

            UpdateRoleCommandResponse response = await Mediator.Send(request);
            if (!response.UpdateRoleInfoDto.Success)
            {
                return Json(response.UpdateRoleInfoDto.Message);
            }
            return Json(response);
        }
    }
}
