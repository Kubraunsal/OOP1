using Genericsİntroo;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> isimler = new MyList<string>();
        isimler.Add("Kübra");

        Console.WriteLine(isimler.Length);

        isimler.Add("Kerem");

        Console.WriteLine(isimler.Length);



    }
}