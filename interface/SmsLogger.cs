using System;
namespace arayuzler;
public class SmsLogger : ILogger
{
    public void WriteLog()
    {
       // throw new NotImplementedException();
       System.Console.WriteLine("Sms Olarak Yazar.");
    }
}