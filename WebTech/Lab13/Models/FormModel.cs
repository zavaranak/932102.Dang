namespace Lab13.Models
{
    public class FormModel
    {
        public string mathOperator { get; set; }
        public double numb1 { get; set; }
        public double numb2 { get; set; }
         
        public double result{get;set;}
        public void GetResult(){
             switch (mathOperator)
        {
            case "plus":
                result = numb1 + numb2;
                break;
            case "minus":
                result = numb1 - numb2;
                break;
            case "mult":
                result = numb1 * numb2;
                break;
            case "div":
                result= numb1 / numb2;
                break;
        }

        }
    }
}