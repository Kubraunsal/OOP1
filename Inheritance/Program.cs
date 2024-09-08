internal class Program
{
    private static void Main(string[] args)
    {
        Person[] persons = new Person[3]
        {
            new Customer{FirstName = "Kübra"},
            new Student{FirstName ="Gamze"},
            new Person{FirstName = "Emre" }
        };
        foreach (var person in persons)
        {
            Console.WriteLine(person.FirstName);
        }
        Console.ReadLine();
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student: Person
    {
        public string Departmen { get; set; } 
    }
}