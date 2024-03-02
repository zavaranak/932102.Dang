using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab12.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Lab12.Controllers;
public class CalcServiceController : Controller
{   
    public void getResult(ref string mathOperator, ref float result, float num1, float num2){
        switch (mathOperator)
        {
            case "plus":
                mathOperator = "+";
                result = num1 + num2;
                break;
            case "minus":
                mathOperator = "-";
                result = num1 - num2;
                break;
            case "mult":
                mathOperator = "*";
                result = num1 * num2;
                break;
            case "div":
                mathOperator = "/";
                result = num1 / num2;
                break;
        }

    }
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
///SingleActions
    [HttpGet]
    public IActionResult Manual(){
    ViewBag.Title ="Manual - Backend2";
    ViewBag.Heading ="Manual";
    return View(); 
    }
    [HttpPost]
    [ActionName("Manual")]
    public IActionResult PostManual()
    {

        var formCollector = HttpContext.Request.Form;
        var num1 = float.Parse(formCollector["firstnum"]);
        var num2 = float.Parse(formCollector["secondnum"]);
        var mathOperator = formCollector["selectedOperator"];
        var result = float.E;
        var mathOp = mathOperator.ToString();
        getResult(ref mathOp, ref result,num1,num2);
        ViewBag.Title = "Result - Backend2";
        ViewBag.Result = $"{num1} {mathOp} {num2} = {result}";
        return View("Result");
    }
///In Separate Handlers
    [HttpGet]
    public IActionResult ManualWithSeparateHandlers(){
        ViewBag.Title ="ManualWithSeparateActions - Backend2";
        ViewBag.Heading ="Manual With Separate Actions";
        return View(); 
    }
    [HttpPost]
    [ActionName("ManualWithSeparateHandlers")]
    public IActionResult PostManualWithSeparateHandlers(){
        ViewBag.Title ="Result2 - Backend2";
        var formCollector = HttpContext.Request.Form;
        var num1 = float.Parse(formCollector["firstnum"]);
        var num2 = float.Parse(formCollector["secondnum"]);
        var mathOperator = formCollector["selectedOperator"];
        var result = float.E;
        var mathOp = mathOperator.ToString();
        getResult(ref mathOp, ref result,num1,num2);
        ViewBag.Result = $"{num1} {mathOp} {num2} = {result}";
        return View("Result");
    }
///Model Binding
    [HttpGet]
    public IActionResult ModelBindingParameters(){
        ViewBag.Title ="ModelBindingParameters - Backend2";
        ViewBag.Heading ="ModelBindingParameters";
        return View(); 
    }
    [HttpPost]
    [ActionName("ModelBindingParameters")]
    public IActionResult PostModelBindingParameters(){
        ViewBag.Title ="Result3 - Backend2";
        var formCollector = HttpContext.Request.Form;
        var formModel = new FormModel{
            numb1 = float.Parse(formCollector["firstnum"]),
            numb2 = float.Parse(formCollector["secondnum"]),
            mathOperator = formCollector["SelectedOperator"]
        };
        formModel.GetResult();
        return View("ResultModel",formModel);
    }
     [HttpGet]
    public IActionResult ModelBindingInSeparateModels(){
        ViewBag.Title ="ModelBindingInSeparateModels - Backend2";
        ViewBag.Heading ="ModelBindingInSeparateModels";
        return View(); 
    }
    [HttpPost]
    [ActionName("ModelBindingInSeparateModels")]
    public IActionResult PostModelBindingInSeparateModels(){
        ViewBag.Title ="Result3 - Backend2";
        var formCollector = HttpContext.Request.Form;
        var formModel = new FormModel{
            numb1 = float.Parse(formCollector["firstnum"]),
            numb2 = float.Parse(formCollector["secondnum"]),
            mathOperator = formCollector["SelectedOperator"]
        };
        formModel.GetResult();
        return View("ResultModel",formModel);
    }
}