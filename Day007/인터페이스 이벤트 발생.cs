
// See https://aka.ms/new-console-template for more information
interface ILogger
{
    void WriteLog(string message);
}
class ConsoleLooger : ILogger
{
    public void WriteLog (string message)
    {
        Console.WriteLine(DateTime.Now.ToLocalTime()+ ":" + message);
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        ConsoleLooger looger = new ConsoleLooger();
        looger.WriteLog("장애 이벤트 발생~!!!");
    }
}
