using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace LearnBySpeaking.Web.Controllers
{
    public class BaseController : Controller
    {
        public Lazy<IMediator> Mediator => new(HttpContext.RequestServices.GetService<IMediator>());
        public Lazy<IMapper> Mapper => new(HttpContext.RequestServices.GetService<IMapper>());

        public void AddErrorModelState(List<string> errors) =>
            errors.ForEach(x => ModelState.AddModelError(string.Empty, x));
    }
}