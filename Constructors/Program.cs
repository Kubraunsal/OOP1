internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer1 = new Customer
        {
            Id = 1,
            FirstName = "Kübra",
            LastName = "Ünsal",
            City = "Ankara"
        };

        Customer customer = new Customer(2, "Derin", "Ünsal", "Ankara");

        Customer customer3 = new Customer();
        customer3.Id = 3;

        Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
        Console.WriteLine(customer2.FirstName);
    }

  
    class Customer
    {public Customer()
        {

        }
        //default connstructor
        public Customer(int id, string firsName, string lastName ,
            string city)
        {
            Id = id;
            FirstName = firsName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}