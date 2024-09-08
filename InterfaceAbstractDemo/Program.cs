using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;

internal partial class Program
{
    private static void Main(string[] args)
    {
        BaseCustomerManager customerManager = new NeroCustomerManager();
        customerManager.Save(new Customer{DateofBirth = new DateTime (1895, 1, 6),
            FirstName = "Kübra",LastName = "Ünsal", NationalityId = "28861499108"});
        Console.ReadLine();
           

    }
}