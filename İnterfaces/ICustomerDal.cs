using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Uptade();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {

            Console.WriteLine("Sql deleted");
        }

        public void Uptade()
        {

            Console.WriteLine("Sql uptaded");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {

            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {

            Console.WriteLine("Oracle deleted");
        }

        public void Uptade()
        {

            Console.WriteLine("Oracle uptaded");
        }
        
        
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {

            Console.WriteLine("MySql added");
        }

        public void Delete()
        {

            Console.WriteLine("MySql deleted");
        }

        public void Uptade()
        {

            Console.WriteLine("MySql uptaded");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
