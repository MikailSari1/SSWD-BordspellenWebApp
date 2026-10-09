using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class AcceptedBoardGameNightController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}