using System.Diagnostics;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class ProfileController : Controller
{
    public IActionResult Index()
    {
        var user = new User("John Doe", "jd12@gmail.com", Gender.Male, new Address("1234 Main St", "Springfield", 1234));
        return View(user);
    }
}