﻿using AuthOperationsApp.Application.Features.Queries.Role.GetAllRole;
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
        public async Task<IActionResult> AllRoles(GetAllRoleQueryRequest request)
        {
            GetAllRoleQueryResponse response = await Mediator.Send(request);

            if (!response.RoleListInfoDtos.Success)
            {
                return View(response.RoleListInfoDtos.Message);
            }
            return View(response);
        }
        
    }
}
