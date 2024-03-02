using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;

namespace Lab13.Models
{
    public class QuizModel(){
        public string mathOperator{ get; set; }
        public double numb1 { get; set; }
        public double numb2 { get; set; }
         
        public double result{get;set;}
        public string answer{get;set;}
        public void DoMath()
        {
        var a = new Random();
        var b = new Random();
        double numb1Temp = (double)a.Next(-100,100);
        double numb2Temp =0.0;
        while (numb2Temp ==0) {numb2Temp = (double)b.Next(-100,100);}
        
        double resultTemp = 0;
        string mathOperatorTemp = "";
        var randomNumber = new Random(4);
        switch (randomNumber.Next(0, 4))
        {
            case 0: resultTemp = numb1Temp + numb2Temp; mathOperatorTemp = "+"; break;
            case 1: resultTemp = numb1Temp - numb2Temp; mathOperatorTemp = "-"; break;
            case 2: resultTemp = numb1Temp * numb2Temp; mathOperatorTemp = "*"; break;
            case 3: resultTemp = numb1Temp / numb2Temp; mathOperatorTemp = "/"; break;
        }

        numb1= numb1Temp;
        numb2 = numb2Temp;
        result = resultTemp;
        mathOperator = mathOperatorTemp;
        }
    }
}


