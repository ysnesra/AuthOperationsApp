using AuthOperationsApp.Application.DTOs.Group;
using AuthOperationsApp.Application.DTOs.Role;
using AuthOperationsApp.Application.Features.Commands.Group.UpdateGroup;
using AuthOperationsApp.Application.Features.Commands.Role.UpdateRole;
using AuthOperationsApp.Application.Features.Queries.Group.GetAllGroup;
using AuthOperationsApp.Application.Features.Queries.Role.GetAllRole;
using AuthOperationsApp.Infrastructure.Base;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthOperationsApp.WEB.Controllers
{
    public class GroupController : BaseController
    {
        public GroupController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public IActionResult AllGroups()
        {
            return View();
        }

        [HttpPost]      
        public async  Task<JsonResult> GetAllGroups()
        {
            GetAllGroupQueryRequest request = new GetAllGroupQueryRequest();
            GetAllGroupQueryResponse response = await Mediator.Send(request);

            if (!response.GroupListInfoDto.Success)
            {
                return Json(new { error = response.GroupListInfoDto.Message });
            }
            return Json(response.GroupListInfoDto.GroupListDto);
        }

        [HttpPost]
        public async Task<JsonResult> UpdateGroup([FromBody] UpdateGroupRequestDto updateGroupRequestDto)
        {
            UpdateGroupCommandRequest request = new UpdateGroupCommandRequest();
            request.Id = Guid.Parse(updateGroupRequestDto.Id);
            request.Name = updateGroupRequestDto.Name;

            UpdateGroupCommandResponse response = await Mediator.Send(request);
            if (!response.UpdateGroupInfoDto.Success)
            {
                return Json(response.UpdateGroupInfoDto.Message);
            }
            return Json(response);
        }
    }
}
