namespace DependencyInjectionT.Logic;


public class NewDemoLogic : IDemoLogic
{
    public int Value1 { get; private set; }
    public int Value2 { get; private set; }

    public NewDemoLogic()
    {
        Value1 = 25;
        Value2 = 50;
    }
}