﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class SmsLoggerService : IloggerService
    {
        public void log()
        {
            Console.WriteLine("Sms yollnadı");
        }
    }
}
