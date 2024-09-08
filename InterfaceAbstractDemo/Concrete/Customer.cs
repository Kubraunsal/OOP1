internal partial class Program
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  DateTime DateofBirth{ get; set; }
        public string NationalityId { get; set; }
    }
}