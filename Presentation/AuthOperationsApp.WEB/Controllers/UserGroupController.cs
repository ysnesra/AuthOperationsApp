
using AuthOperationsApp.Application.DTOs.UserGroup;
using AuthOperationsApp.Application.Features.Commands.UserGroup.AssignUserToGroup;
using AuthOperationsApp.Application.Features.Commands.UserGroup.UnassignUserToGroup;
using AuthOperationsApp.Application.Features.Queries.User.GetAllUserByGroup;
using AuthOperationsApp.Application.Features.Queries.User.GetAllUserNoGroup;
using AuthOperationsApp.Infrastructure.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace AuthOperationsApp.WEB.Controllers
{
    public class UserGroupController : BaseController
    {
        public UserGroupController(IMediator mediator) : base(mediator)
        {
        }

        //Gruptaki Kullanıcılar kutucuğu - Grupta olmayan Kullanıcılar Kutucuğu Ekranı
        [HttpGet]
        public async Task<IActionResult> AllUsersByGroup(Guid id)
        {
            ViewBag.GroupId = id;
            ViewBag.GroupName = "";
            return View();
        }

        //Grubun sahip olduğu Kullanıcılar kutucuğu
        [HttpPost]
        public async Task<JsonResult> UsersByGroup([FromBody] string GroupId)
        {
            GetAllUserByGroupQueryRequest request = new GetAllUserByGroupQueryRequest();
            request.GroupId = Guid.Parse(GroupId);
            GetAllUserByGroupQueryResponse response = await Mediator.Send(request);

            if (response.UserByGroupInfoDto.Success)
                return Json(response.UserByGroupInfoDto.UserByGroupDto);
            else
                return Json(new { error = response.UserByGroupInfoDto.Message });
        }

        // Grubun sahip olmadığı Kullanıcılar kutucuğu
        [HttpPost]
        public async Task<JsonResult> UsersNoGroup([FromBody] string GroupId)
        {
            GetAllUserNoGroupQueryRequest request = new GetAllUserNoGroupQueryRequest();
            request.GroupId = Guid.Parse(GroupId);

            GetAllUserNoGroupQueryResponse response = await Mediator.Send(request);

            if (!response.AllUserNoGroupInfoDto.Success)
            {
                Json(new { error = response.AllUserNoGroupInfoDto.Message });
            }

            return Json(response.AllUserNoGroupInfoDto.AllUserNoGroupDto);
        }

        //Gruba Kullanıcı atama 
        [HttpPost]
        public async Task<JsonResult> AssignUserToGroup([FromBody] AssignUserRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                AssignUserToGroupCommandRequest request = new AssignUserToGroupCommandRequest();
                request.GroupId = Guid.Parse(requestDto.GroupId);
                request.UserId = Guid.Parse(requestDto.UserId);

                AssignUserToGroupCommandResponse response = await Mediator.Send(request);

                if (response.AssignUserToGroupInfoDto.Success)
                    return Json(response.AssignUserToGroupInfoDto.Message);
                else
                    return Json(new { error = response.AssignUserToGroupInfoDto.Message });
            }
            return Json(new { error = "Invalid model state" });
        }

        //Gruptan Kullanıcı atamasını kaldırma
        [HttpPost]
        public async Task<JsonResult> UnassignUserToGroup([FromBody] UnassignUserRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                UnassignUserToGroupCommandRequest request = new UnassignUserToGroupCommandRequest();
                request.GroupId = Guid.Parse(requestDto.GroupId);
                request.UserId = Guid.Parse(requestDto.UserId);

                UnassignUserToGroupCommandResponse response = await Mediator.Send(request);

                if (response.UnassignUserToGroupInfoDto.Success)
                    return Json(response.UnassignUserToGroupInfoDto.Message);
                else
                    return Json(new { error = response.UnassignUserToGroupInfoDto.Message });
            }
            return Json(new { error = "Invalid model state" });
        }
    }
}
