using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab11.Models;
using Microsoft.AspNetCore.Components.Web;

namespace Lab11.Controllers;

public class ICalcService{
    public string Title{get;set;}
    public string Heading{get;set;}
    public int numb1{get;set;}
    public int numb2{get;set;}
}
public class CalcServiceController : Controller
{   
    private readonly ICalcService _calcService;
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
            numb1 = rnd.Next(0,100),
            numb2 = rnd.Next(1,100),
        };
        return View(modelPUM);
    }
    public IActionResult PassUsingViewData()
    {
        var rnd = new Random();
        ViewData["Title"] ="PassUsingViewBag - Backend1";
        ViewData["Heading"] ="PassUsingViewBag";
        ViewData["numb1"] = rnd.Next(0,100);
        ViewData["numb2"] = rnd.Next(1,100);
        return View();
    }
    public IActionResult PassUsingViewBag()
    {
        var rnd = new Random();
        ViewBag.Title ="PassUsingViewBag - Backend1";
        ViewBag.Heading ="PassUsingViewBag";
        ViewBag.numb1 = rnd.Next(0,100);
        ViewBag.numb2 = rnd.Next(1,100);
        return View();
    }
     public IActionResult PassUsingServiceDirectly()
    {
        var rnd = new Random();
        _calcService.Title ="PassUsingServiceDirectly - Backend1";
        _calcService.Heading ="PassUsingServiceDirectly";
        _calcService.numb1 = rnd.Next(0,100);
        _calcService.numb2 = rnd.Next(1,100);
        return View();
    }
}
