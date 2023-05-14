using Microsoft.AspNetCore.Mvc; 

namespace WebUI.Controllers;

public class HomeController : Controller
{ 
    public IActionResult Index()
    {
        // Sadece kendi controller'larından kendi View'lerine
        ViewData["Str"] = "String Value ViewData";
        ViewData["Num"] = 11111;

        // Sadece kendi controller'larından kendi View'lerine
        ViewBag.String = "String Value ViewBag";
        ViewBag.Number = 22222;

        TempData["Str"] = "String Value TempData";
        TempData["Num"] = 33333;
        TempData["Privacy"] = "Privacy";

        return View();
    }

    public IActionResult Privacy()
    { 
        return View();
    } 
}