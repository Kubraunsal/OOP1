using classes;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Uptade();

        ProductManager productManager = new ProductManager();
        productManager.Add();

        Customer customer = new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Kübra";
        customer.LastName = "Ünsal";

        Customer customer2 = new Customer
        {
            Id = 2, City ="İstanbul", FirstName = "Derin",
            LastName = "Demiroğ"
        };
        Console.WriteLine(customer2.FirstName);


        Console.ReadLine();
    
    }
    
    }


