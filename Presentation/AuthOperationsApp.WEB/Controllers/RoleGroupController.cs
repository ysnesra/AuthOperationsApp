using AuthOperationsApp.Application.DTOs.RoleGroup;
using AuthOperationsApp.Application.Features.Commands.RoleGroup.AssignGroupToRole;
using AuthOperationsApp.Application.Features.Commands.RoleGroup.UnassignGroupToRole;
using AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupByRole;
using AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroupNoRole;
using AuthOperationsApp.Infrastructure.Base;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace AuthOperationsApp.WEB.Controllers
{
    public class RoleGroupController : BaseController
    {
        public RoleGroupController(IMediator mediator) : base(mediator)
        {
        }

        //Yetkinin bağlı olduğu Gruplar kutucuğu - Yekisiz Gruplar Kutucuğu Ekranı
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AllGroupsByRole(Guid RoleId)
        {
            ViewBag.RoleId = RoleId;    
         
            return View();
        }

        //Yetkinin bağlı olduğu Gruplar

        [HttpPost]
        [AllowAnonymous]
        public async Task<JsonResult> GroupsByRole([FromBody] string RoleId)
        {
           
            GetAllGroupByRoleQueryRequest request=new GetAllGroupByRoleQueryRequest();
            request.RoleId = Guid.Parse(RoleId);
            GetAllGroupByRoleQueryResponse response = await Mediator.Send(request);

            if (response.GroupByRoleInfoDto.Success)
                return Json(response.GroupByRoleInfoDto.GroupByRoleDto);
            else
                return Json(new { error = response.GroupByRoleInfoDto.Message });
        }

        //Grubu yetkiye atama
        //Yetkisi olmayan Gruplar kutucuğu
      
        [HttpPost]
        [AllowAnonymous]
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


    }
}
