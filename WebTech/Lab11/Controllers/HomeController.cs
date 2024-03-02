using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab11.Models;
using Microsoft.AspNetCore.Components.Web;

namespace Lab11.Controllers;
public class CalcServiceController : Controller
{   
    public IActionResult Home()
    {
        
        var modelHOME = new HomeModel
        {
        UsingActions = [ "Using Model Calc", "Using ViewData Calc", "Using ViewBag Calc", "Using Service Injection Calc" ],
        Title = "Home Page - Backend1",
        Heading = "Calc Service Demonstration"
        };
        return View(modelHOME);
    }
    public IActionResult PassUsingModel()
    {
        var rnd = new Random();
        var modelPUM = new PassModel{
            Title ="PassUsingModel - Backend1",
            Heading ="PassUsingModel",
            numb1 = rnd.Next(0,10),
            numb2 = rnd.Next(1,10),
        };
        return View(modelPUM);
    }
    public IActionResult PassUsingViewData()
    {
        var rnd = new Random();
        ViewData["Title"] ="PassUsingViewBag - Backend1";
        ViewData["Heading"] ="PassUsingViewBag";
        ViewData["numb1"] = rnd.Next(0,10);
        ViewData["numb2"] = rnd.Next(1,10);
        return View();
    }
    public IActionResult PassUsingViewBag()
    {
        var rnd = new Random();
        ViewBag.Title ="PassUsingViewBag - Backend1";
        ViewBag.Heading ="PassUsingViewBag";
        ViewBag.numb1 = rnd.Next(0,10);
        ViewBag.numb2 = rnd.Next(1,10);
        return View();
    }
     public IActionResult PassUsingServiceDirectly()
    {
        return View();
    }
}
