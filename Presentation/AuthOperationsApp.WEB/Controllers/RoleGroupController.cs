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
                return Json(response.AllGroupNoRoleInfoDto.Message);
            }
            return Json(new { error = response.AllGroupNoRoleInfoDto.Message });
        }

        //[HttpPost]
        //public async Task<JsonResult> AssignGroupToRole([FromBody] string[] LessonId)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        SelectLessonByStudentCommandRequest request = new SelectLessonByStudentCommandRequest();

        //        List<Guid> less = new List<Guid>();

        //        foreach (var item in LessonId)
        //        {
        //            less.Add(Guid.Parse(item));
        //        }

        //        request.LessonIds = less;

        //        SelectLessonByStudentCommandResponse response = await Mediator.Send(request);

        //        if (response.StudentLessonResponseDto.Success)
        //            return Json("Ok");
        //        else
        //            return Json(new { error = response.StudentLessonResponseDto.Message });
        //    }
        //    return Json(new { error = "Invalid model state" });
        //}
    }
}
