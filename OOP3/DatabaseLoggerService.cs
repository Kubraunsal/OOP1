using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class DatabaseLoggerService:IloggerService
    {
        public void log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
    public class FileaseLoggerService : IloggerService, IFileaseLoggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}


