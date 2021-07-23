using System;

namespace DataTypeIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] roll=new int [5] { 20, 30, 40, 50, 45 };
            double[] number = new double[5];
            float [] myFloat = new float [5];
            string[] names = new string[5] { "ahmed", "james", "Jone", "shazz", "rahman" };
            DateTime[] myTime = new DateTime[5];
            Decimal[] deciArray = new Decimal[5];
            long[] myNum = new long[5];
            bool[] myBool = new bool[5];

            roll[0] = 20;
            roll[1] = 30;
            roll[2] = 40;
            roll[3] = 50;
            roll[4] = 45;
            

            number[0] = 1.887D;
            number[1] = 34.34D;
            number[2] = 144.56D;
            number[3] = 2333.22D;
            number[4] = 45678.55D;

            myFloat[0] = 1.66F;
            myFloat[1] = 2.677F;
            myFloat[2] = 133.66F;
            myFloat[3] = 14.66F;
            myFloat[4] = 33.66F;

            names[0] = "ahmed";
            names[1] = "james";
            names[2] = "Jone";
            names[3] = "shazz";
            names[4] = "rahman";

          
            myTime[0] = new DateTime(2021, 10, 12);
            myTime[1] = new DateTime(2022, 11, 13);
            myTime[2] = new DateTime(2023, 10, 12);
            myTime[3] = new DateTime(2024, 12, 09);
            myTime[4] = new DateTime(2025, 10, 12);

            deciArray[0] = 1.87m;
            deciArray[1] = 21.6887m;
            deciArray[2] = 133.78887m;
            deciArray[3] = 441.6887m;
            deciArray[4] = 551.4887m;

            myNum[0] = 456789L;
            myNum[1] = 78309838L;
            myNum[2] = 987655L;
            myNum[3] = 45678L;
            myNum[4] = 987656776L;

            myBool[0] = true;
            myBool[1] = false;
            myBool[2] = false;
            myBool[3] = true;
            myBool[4] = true;


            Console.WriteLine("print integer number");
            foreach (int i in roll)
            { Console.WriteLine(i); }

            Console.WriteLine("print double number");
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine(number[3]);
            Console.WriteLine(number[4]);


            Console.WriteLine("print long number");
            Console.WriteLine(myNum[0]);
            Console.WriteLine(myNum[1]);
            Console.WriteLine(myNum[2]);
            Console.WriteLine(myNum[3]);
            Console.WriteLine(myNum[4]);



            Console.WriteLine("print float numbers");
            foreach (int i in myFloat)
            { Console.WriteLine(i); }

            Console.WriteLine("print string names");
            foreach (string i in names)
            { Console.WriteLine(i); }

            Console.WriteLine("print dates");
            Console.WriteLine(myTime[0]);
            Console.WriteLine(myTime[1]);
            Console.WriteLine(myTime[2]);
            Console.WriteLine(myTime[3]);
            Console.WriteLine(myTime[4]);

            Console.WriteLine("print boolen value");
            foreach (bool res in myBool)
                Console.WriteLine(res);

        }
    }
}
