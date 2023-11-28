
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthOperationsApp.Infrastructure.Base
{
    public abstract class BaseController : Controller
    {
        protected readonly IMediator Mediator;
       
        protected BaseController(IMediator mediator)
        {
            Mediator = mediator;
           
        }
    }
}
