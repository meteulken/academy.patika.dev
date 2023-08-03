
// Interface nedir? Interface'ler, birbirine benzeyen ama farklı işlevleri olan sınıflar için kullanılır.
// Interface'ler, içerisinde sadece imza bulunan, içi boş metodlardır. İmza, metodun adı, parametreleri ve dönüş tipinden oluşur.


namespace arayuzler;
class Program
{
    static void Main(string[] args)
    {
        FileLogger fileLogger = new FileLogger();
        fileLogger.WriteLog();

        DatabaseLogger databaseLogger = new DatabaseLogger();
        databaseLogger.WriteLog();

        SmsLogger smsLogger = new SmsLogger();
        smsLogger.WriteLog();

        LogManager logManager = new LogManager(new FileLogger());

        logManager.WriteLog();


    }
}