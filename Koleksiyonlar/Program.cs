﻿using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        //string[] isimler = new string[] {"kübra","kerem","emre","gamze"};
        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);
        //Console.WriteLine(isimler[3]);

        //isimler = new string[5];
        //isimler[4] = "ilker";
        //Console.WriteLine(isimler[4]);
        //Console.WriteLine(isimler[0]);

        List<string> isimler2 = new List<string> { "kübra", "kerem", "emre", "gamze" };
        Console.WriteLine(isimler2[0]);
        Console.WriteLine(isimler2[1]);
        Console.WriteLine(isimler2[2]);
        Console.WriteLine(isimler2[3]);
        isimler2.Add("ilker");
        Console.WriteLine(isimler2[4]);
        Console.WriteLine(isimler2[0]);



    }
}
