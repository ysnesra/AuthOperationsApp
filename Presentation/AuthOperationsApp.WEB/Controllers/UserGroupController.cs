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

        ////Grubun sahip olduğu Kullanıcılar kutucuğu
        //[HttpPost]
        //public async Task<JsonResult> UsersByGroup([FromBody] string GroupId)
        //{
        //    GetAllUserByGroupQueryRequest request = new GetAllUserByGroupQueryRequest();
        //    request.GroupId = Guid.Parse(GroupId);
        //    GetAllUserByGroupQueryResponse response = await Mediator.Send(request);

        //    if (response.UserByGroupInfoDto.Success)
        //        return Json(response.UserByGroupInfoDto.UserByGroupDto);
        //    else
        //        return Json(new { error = response.UserByGroupInfoDto.Message });
        //}

        //// Grubun sahip olmadığı Kullanıcılar kutucuğu
        //[HttpPost]
        //public async Task<JsonResult> UsersNoGroup([FromBody] string GroupId)
        //{
        //    GetAllUserNoGroupQueryRequest request = new GetAllUserNoGroupQueryRequest();
        //    request.GroupId = Guid.Parse(GroupId);

        //    GetAllUserNoGroupQueryResponse response = await Mediator.Send(request);

        //    if (!response.AllUserNoGroupInfoDto.Success)
        //    {
        //        Json(new { error = response.AllUserNoGroupInfoDto.Message });
        //    }

        //    return Json(response.AllUserNoGroupInfoDto.AllUserNoGroupDto);
        //}
    }
}
