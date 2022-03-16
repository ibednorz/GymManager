﻿using GymManager.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GymManager.UI.Controllers;

public class HomeController : BaseController
{
    public async Task<IActionResult> Index()
    {
        //var ticket = await Mediator.Send(new GetTicketByIdQuery { Id = 1 });
        //await Mediator.Send(new AddTicketCommand { Name = "Ticket 1" });
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
