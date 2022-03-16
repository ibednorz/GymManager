﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers;

public abstract class BaseController : Controller
{
    private ISender _mediatr;
    protected ISender Madiatr => _mediatr ??= HttpContext.RequestServices.GetService<ISender>();
}