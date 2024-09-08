using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Method injection
        private object kredi;

        public void BasvuruYap(IKrediManager krediManager, IloggerService  loggerService) 
        {
            //Başvuran bilgilerini değerlendirme 

            krediManager.Hesapla();
            loggerService.log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
               kredi.Hesapla();
            }  
        }
    }
}
