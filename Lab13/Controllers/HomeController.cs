using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab13.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace Lab13.Controllers;
public class ServiceController : Controller
{   
    private static List<QuizModel> questions = new List<QuizModel>();
    public static int currentQuiz = 0;

    public int findTrueAns(List<QuizModel> questions){
        int trueAns = 0;
        questions.ForEach(question => {
            if (Math.Abs(question.result - Double.Parse(question.answer))<0.01){
                trueAns++;
            }
        });
        return trueAns;
    }
    [Route("")]
    [Route("/Mockups")]
    public IActionResult Mockups()
    {
        ViewBag.Title = "Hello Mockups - Backend3";
        ViewBag.Heading = "Mockups";
        return View();
    }
    [Route("/Home")]
    public IActionResult Home()
    {
        currentQuiz = 0;
        questions.Clear();
        var modelHOME = new HomeModel
        {
        UsingActions = [ "Using Model Calc", "Using ViewData Calc", "Using ViewBag Calc", "Using Service Injection Calc" ],
        Title = "Home Page - Backend1",
        Heading = "Calc Service Demonstration"
        };
        return View(modelHOME);
    }
    [Route("/Mockups/Quiz")]
    [HttpGet]
    public IActionResult Quiz()
    {   
        currentQuiz = 0;
        questions.Clear();
        var question = new QuizModel();
        question.DoMath();
        questions.Add(question);
        ViewBag.numb1 = question.numb1;
        ViewBag.numb2 = question.numb2;
        ViewBag.mathOperator = question.mathOperator;
        return View("Views/Service/Mockups/Quiz.cshtml");
    }
    [Route("/Mockups/Quiz")]
    [HttpPost]
    public IActionResult QuizNext(AnswerModel model)     
    {   
        if(ModelState.IsValid){
        questions[currentQuiz].answer = model.answer;
        ModelState.Clear();
        currentQuiz++;
        var question = new QuizModel();
        question.DoMath();
        questions.Add(question);
        ViewBag.numb1 = question.numb1;
        ViewBag.numb2 = question.numb2;
        ViewBag.mathOperator = question.mathOperator;
        return View("Views/Service/Mockups/Quiz.cshtml");
        }
        ViewBag.ErrorMessage = "Ответ не подходит";
        ViewBag.numb1 = questions[currentQuiz].numb1;
        ViewBag.numb2 = questions[currentQuiz].numb2;
        ViewBag.mathOperator = questions[currentQuiz].mathOperator;
        return View("Views/Service/Mockups/Quiz.cshtml", model);
    }
    [Route("/Mockups/QuizResult")]
    [HttpGet]
    public IActionResult QuizResult(){
        ViewBag.TrueAns= findTrueAns(questions);
        return View("Views/Service/Mockups/QuizResult.cshtml",questions);
    }
    [Route("/Mockups/QuizResult")]
    [HttpPost]
    public IActionResult QuizResultPost(AnswerModel model){
        if (ModelState.IsValid){
        questions[currentQuiz].answer = model.answer;
        ViewBag.TrueAns= findTrueAns(questions);
        return View("Views/Service/Mockups/QuizResult.cshtml",questions);
        };
        ViewBag.ErrorMessage = "Ответ не подходит";
        ViewBag.numb1 = questions[currentQuiz].numb1;
        ViewBag.numb2 = questions[currentQuiz].numb2;
        ViewBag.mathOperator = questions[currentQuiz].mathOperator;
        return View("Views/Service/Mockups/Quiz.cshtml", model);
    }
    ///Lab12 Extended
                    public void getResult(ref string mathOperator, ref double result, double num1, double num2){
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
                        var num1 = double.Parse(formCollector["firstnum"]);
                        var num2 = double.Parse(formCollector["secondnum"]);
                        var mathOperator = formCollector["selectedOperator"];
                        var result = double.E;
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
                        var num1 = double.Parse(formCollector["firstnum"]);
                        var num2 = double.Parse(formCollector["secondnum"]);
                        var mathOperator = formCollector["selectedOperator"];
                        var result = double.E;
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
                            numb1 = Double.Parse(formCollector["firstnum"]),
                            numb2 = Double.Parse(formCollector["secondnum"]),
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
                            numb1 = Double.Parse(formCollector["firstnum"]),
                            numb2 = Double.Parse(formCollector["secondnum"]),
                            mathOperator = formCollector["SelectedOperator"]
                        };
                        formModel.GetResult();
                        return View("ResultModel",formModel);
                    }
}
