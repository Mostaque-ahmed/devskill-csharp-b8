﻿using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = ConvertTime("12:30 pm");
            Console.WriteLine(result);
        }

        public static string ConvertTime(string twelveHourFormat)
        {
            return DateTime.Parse(twelveHourFormat).ToString("HH:mm"); 


            throw new NotImplementedException();
        }
    }
}
