using AuthOperationsApp.Application.DTOs.RoleGroup;
using AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignGroupToRole;
using AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignRoleToGroup;
using AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignGroupToRole;
using AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignRoleToGroup;
using AuthOperationsApp.Application.Features.Queries.Role.GetAllRoleByGroup;
using AuthOperationsApp.Application.Features.Queries.Role.GetAllRoleNoGroup;
using AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole;
using AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupNoRole;
using AuthOperationsApp.Infrastructure.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace AuthOperationsApp.WEB.Controllers
{
    public class RoleGroupController : BaseController
    {
        public RoleGroupController(IMediator mediator) : base(mediator)
        {
        }

        //Yetkinin bağlı olduğu Gruplar kutucuğu - Yetkisiz Gruplar Kutucuğu Ekranı
        [HttpGet]
        public async Task<IActionResult> AllGroupsByRole(Guid id)
        {
            ViewBag.RoleId = id;
            ViewBag.RoleName = "";
         
            return View();
        }

        //Yetkinin bağlı olduğu Gruplar
        [HttpPost]
        public async Task<JsonResult> GroupsByRole([FromBody] string RoleId)
        {
           
            GetAllGroupByRoleQueryRequest request=new GetAllGroupByRoleQueryRequest();
            request.RoleId = Guid.Parse(RoleId);
            GetAllGroupByUserQueryResponse response = await Mediator.Send(request);

            if (response.GroupByRoleInfoDto.Success)
                return Json(response.GroupByRoleInfoDto.GroupByRoleDto);
            else
                return Json(new { error = response.GroupByRoleInfoDto.Message });
        }

        //Yetkisi olmayan Gruplar kutucuğu   
        [HttpPost]
        public async Task<JsonResult> GroupsNoRole([FromBody] string RoleId)
        {
            GetAllGroupNoRoleQueryRequest request = new GetAllGroupNoRoleQueryRequest();
            request.RoleId = Guid.Parse(RoleId);

            GetAllGroupNoRoleQueryResponse response = await Mediator.Send(request);

            if (!response.AllGroupNoRoleInfoDto.Success)
            {
                Json(new { error = response.AllGroupNoRoleInfoDto.Message });
            }

            return Json(response.AllGroupNoRoleInfoDto.AllGroupNoRoleDto);
        }

        //Role Grup atama 
        [HttpPost]
        public async Task<JsonResult> AssignGroupToRole([FromBody] AssignGroupRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                AssignGroupToRoleCommandRequest request = new AssignGroupToRoleCommandRequest();
                request.GroupId = Guid.Parse(requestDto.GroupId);
                request.RoleId = Guid.Parse(requestDto.RoleId);

                AssignGroupToRoleCommandResponse response = await Mediator.Send(request);

                if (response.AssignGroupToRoleInfoDto.Success)
                    return Json(response.AssignGroupToRoleInfoDto.Message);
                else
                    return Json(new { error = response.AssignGroupToRoleInfoDto.Message });
            }

            return Json(new { error = "Invalid model state" });
        }

        //Roleden Grup atamasını kaldırma
        [HttpPost]
        public async Task<JsonResult> UnassignGroupToRole([FromBody]UnassignGroupRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                UnassignGroupToRoleCommandRequest request = new UnassignGroupToRoleCommandRequest();
                request.GroupId = Guid.Parse(requestDto.GroupId);
                request.RoleId = Guid.Parse(requestDto.RoleId);

                UnassignGroupToRoleCommandResponse response = await Mediator.Send(request);

                if (response.UnassignGroupToRoleInfoDto.Success)
                    return Json(response.UnassignGroupToRoleInfoDto.Message);
                else
                    return Json(new { error = response.UnassignGroupToRoleInfoDto.Message });
            }
            return Json(new { error = "Invalid model state" });
        }

        //Grubun sahip oldupu Yetkiler kutucuğu - Grubun sahip olmadığı Yetkiler Kutucuğu Ekranı
        [HttpGet]
        public async Task<IActionResult> AllRolesByGroup(Guid id)
        {
            ViewBag.GroupId = id;
            ViewBag.GroupName = "";
            return View();
        }

        //Grubun sahip olduğu Yetkiler kutucuğu
        [HttpPost]
        public async Task<JsonResult> RolesByGroup([FromBody] string GroupId)
        {
            GetAllRoleByGroupQueryRequest request = new GetAllRoleByGroupQueryRequest();
            request.GroupId = Guid.Parse(GroupId);
            GetAllRoleByGroupQueryResponse response = await Mediator.Send(request);

            if (response.RoleByGroupInfoDto.Success)
                return Json(response.RoleByGroupInfoDto.RoleByGroupDto);
            else
                return Json(new { error = response.RoleByGroupInfoDto.Message });
        }

         // Grubun sahip olmadığı Yetkiler kutucuğu
        [HttpPost]
        public async Task<JsonResult> RolesNoGroup([FromBody] string GroupId)
        {
            GetAllRoleNoGroupQueryRequest request = new GetAllRoleNoGroupQueryRequest();
            request.GroupId = Guid.Parse(GroupId);

            GetAllRoleNoGroupQueryResponse response = await Mediator.Send(request);

            if (!response.AllRoleNoGroupInfoDto.Success)
            {
                Json(new { error = response.AllRoleNoGroupInfoDto.Message });
            }

            return Json(response.AllRoleNoGroupInfoDto.AllRoleNoGroupDto);
        }

        //Gruba Role atama 
        [HttpPost]
        public async Task<JsonResult> AssignRoleToGroup([FromBody] AssignRoleRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                AssignRoleToGroupCommandRequest request = new AssignRoleToGroupCommandRequest();
                request.GroupId = Guid.Parse(requestDto.GroupId);
                request.RoleId = Guid.Parse(requestDto.RoleId);

                AssignRoleToGroupCommandResponse response = await Mediator.Send(request);

                if (response.AssignRoleToGroupInfoDto.Success)
                    return Json(response.AssignRoleToGroupInfoDto.Message);
                else
                    return Json(new { error = response.AssignRoleToGroupInfoDto.Message });
            }
            return Json(new { error = "Invalid model state" });
        }

        //Gruptan Role atamasını kaldırma
        [HttpPost]
        public async Task<JsonResult> UnassignRoleToGroup([FromBody] UnassignRoleRequestDto requestDto)
        {
            if (ModelState.IsValid)
            {
                UnassignRoleToGroupCommandRequest request = new UnassignRoleToGroupCommandRequest();
                request.GroupId = Guid.Parse(requestDto.GroupId);
                request.RoleId = Guid.Parse(requestDto.RoleId);

                UnassignRoleToGroupCommandResponse response = await Mediator.Send(request);

                if (response.UnassignRoleToGroupInfoDto.Success)
                    return Json(response.UnassignRoleToGroupInfoDto.Message);
                else
                    return Json(new { error = response.UnassignRoleToGroupInfoDto.Message });
            }
            return Json(new { error = "Invalid model state" });
        }
    }
}
