using OOP3;

internal class Program
{ 
    private static void Main(string[] args)
    {
        IKrediManager İhtiyacKrediManager = new İhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasıtKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();

        IloggerService databaseloggerService = new DatabaseLoggerService();
        IloggerService filelogerService = new FileaseLoggerService();
        

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(new EsnafKredisiManager(),
            new SmsLoggerService());

        List<IKrediManager> krediler = new List<IKrediManager>() {İhtiyacKrediManager, tasitKrediManager};
        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

    }
}   