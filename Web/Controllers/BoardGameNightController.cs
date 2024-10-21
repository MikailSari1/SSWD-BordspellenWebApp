using System.Diagnostics;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class BoardGameNightController : Controller
{
    public IActionResult Index()
    {
        /*var  = new boardGameNight("Game Night", new DateTime(2022, 1, 1, 18, 0, 0), new Address("1234 Main St", "Springfield", 1234));*/
        return View();
    }
}