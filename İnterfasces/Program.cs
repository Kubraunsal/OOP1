internal class Program
{
    // interface new'lenemez

    private static void Main(string[] args, CustomerManager customerManager)
    {
        IPersonManager personManager = new CustomerManager();
        customerManager.Add();
    }
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Uptade();
    }
    //inherits - class ------------ implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları 

            Console.WriteLine("Müşteri eklendi");
        }

        public void Uptade()
        {

            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManagar : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları 

            Console.WriteLine("Personel eklendi");
        }

        public void Uptade()
        {

            Console.WriteLine("porselen güncellendi");
        }
    }
    }
