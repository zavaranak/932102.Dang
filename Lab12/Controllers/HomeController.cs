using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab12.Models;
using Microsoft.AspNetCore.Components.Web;

namespace Lab12.Controllers;
public class CalcServiceController : Controller
{   
    public IActionResult Home()
    {
        
        var modelHOME = new HomeModel
        {
        UsingActions = [ "Manual parsing in single action", "Manual parsing in separate actions", "Model binding(parameters)", "Model binding (separeate model)" ],
        Title = "Home Page - Backend2",
        Heading = "Form parameters parsing demo"
        };
        return View(modelHOME);
    }
    public IActionResult Manual()
    {
        ViewBag.Title ="Manual - Backend2";
        ViewBag.Heading ="Manual";
        return View();
    }

    public IActionResult Result()
    {
        ViewBag.Title = "Result - Backend2";
        ViewBag.Heading = "Result";
        ViewBag.numb1 = HttpContext.Request.Form["firstnum"];
        ViewBag.numb2 = HttpContext.Request.Form["secondnum"];
        ViewBag.math = HttpContext.Request.Form["selectedOperator"];
        return View();
    }
}