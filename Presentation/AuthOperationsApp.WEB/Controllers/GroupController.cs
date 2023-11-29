using AuthOperationsApp.Application.Features.Queries.RoleGroup.GetAllGroup;
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
        [AllowAnonymous]
        public async Task<IActionResult> AllGroups(GetAllGroupQueryRequest request)
        {
            GetAllGroupQueryResponse response = await Mediator.Send(request);

            if (!response.GroupListInfoDto.Success)
            {
                return View(response.GroupListInfoDto.Message);
            }
            return View(response);
        }

    }
}
