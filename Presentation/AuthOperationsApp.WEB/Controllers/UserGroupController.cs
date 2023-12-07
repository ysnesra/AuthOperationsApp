using AuthOperationsApp.Application.DTOs.RoleGroup;
using AuthOperationsApp.Application.DTOs.UserGroup;
using AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignRoleToGroup;
using AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignRoleToGroup;
using AuthOperationsApp.Application.Features.Commands.UserGroup.AssignGroupToUser;
using AuthOperationsApp.Application.Features.Commands.UserGroup.AssignUserToGroup;
using AuthOperationsApp.Application.Features.Commands.UserGroup.UnassignGroupToUser;
using AuthOperationsApp.Application.Features.Commands.UserGroup.UnassignUserToGroup;
using AuthOperationsApp.Application.Features.Queries.Group.GetAllGroupByUser;
using AuthOperationsApp.Application.Features.Queries.Group.GetAllGroupNoUser;
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

        //******************************************
        //Kullanıcının bağlı olduğu Gruplar kutucuğu - Kullanıcının bağlı olmadığı Gruplar Kutucuğu Ekranı
        [HttpGet]
        public async Task<IActionResult> AllGroupsByUser(Guid id)
        {
            ViewBag.UserId = id;
            ViewBag.FullName = "";
            return View();
        }
        //Kullanıcının bulunduğu Gruplar kutucuğu
        [HttpPost]
        public async Task<JsonResult> GroupsByUser([FromBody] string UserId)
        {
            GetAllGroupByUserQueryRequest request = new GetAllGroupByUserQueryRequest();
            request.UserId = Guid.Parse(UserId);
            GetAllGroupByUserQueryResponse response = await Mediator.Send(request);

            if (response.GroupByUserInfoDto.Success)
                return Json(response.GroupByUserInfoDto.GroupByUserDto);
            else
                return Json(new { error = response.GroupByUserInfoDto.Message });
        }

        // Kullanıcının bulunmadığı Gruplar kutucuğu
        [HttpPost]
        public async Task<JsonResult> GroupsNoUser([FromBody] string UserId)
        {
            GetAllGroupNoUserQueryRequest request = new GetAllGroupNoUserQueryRequest();
            request.UserId = Guid.Parse(UserId);

            GetAllGroupNoUserQueryResponse response = await Mediator.Send(request);

            if (!response.AllGroupNoUserInfoDto.Success)
            {
                Json(new { error = response.AllGroupNoUserInfoDto.Message });
            }

            return Json(response.AllGroupNoUserInfoDto.AllGroupNoUserDto);
        }

        //Kullanıcıya Grup atama 
        [HttpPost]
        public async Task<JsonResult> AssignGroupToUser([FromBody] AssignGroupForUserRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                AssignGroupToUserCommandRequest request = new AssignGroupToUserCommandRequest();
                request.GroupId = Guid.Parse(requestDto.GroupId);
                request.UserId = Guid.Parse(requestDto.UserId);

                AssignGroupToUserCommandResponse response = await Mediator.Send(request);

                if (response.AssignGroupToUserInfoDto.Success)
                    return Json(response.AssignGroupToUserInfoDto.Message);
                else
                    return Json(new { error = response.AssignGroupToUserInfoDto.Message });
            }
            return Json(new { error = "Invalid model state" });
        }

        //Kullanıcıdan Grup atamasını kaldırma
        [HttpPost]
        public async Task<JsonResult> UnassignGroupToUser([FromBody] UnassignGroupForUserRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                UnassignGroupToUserCommandRequest request = new UnassignGroupToUserCommandRequest();
                request.GroupId = Guid.Parse(requestDto.GroupId);
                request.UserId = Guid.Parse(requestDto.UserId);

                UnassignGroupToUserCommandResponse response = await Mediator.Send(request);

                if (response.UnassignGroupToUserInfoDto.Success)
                    return Json(response.UnassignGroupToUserInfoDto.Message);
                else
                    return Json(new { error = response.UnassignGroupToUserInfoDto.Message });
            }
            return Json(new { error = "Invalid model state" });
        }

    }
}
