using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface GamerManager : IGamerService
    {
        //MicroService
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt oldu");

        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
        public void Uptade(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
