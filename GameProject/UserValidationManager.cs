using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserVlidationService
    {
        public void Validate(Gamer gamer)
        {
            if (gamer.BirthYear != 1985 || gamer.FirstName != "Kübra" || gamer.LastName != "ÜNSAL"
                gamer.IdentiyNumber == 12345)
            {

            }
        }
    }
}
