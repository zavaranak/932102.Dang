public interface ICalcService{
    public int Getnumb1();
    public int Getnumb2();

    public string GetHeading();
    public string GetTitle();
}
public class CalcService:ICalcService
{
    public int Getnumb1(){
        var rnd = new Random();
        return rnd.Next(0,10);
    }
    public int Getnumb2(){
        var rnd = new Random();
        return rnd.Next(1,10);
    }
    public string GetHeading(){
        return "AccessServiceDirectly";
    }
    public string GetTitle(){
        return "AccessServiceDirectly - Backend1";
    }
}