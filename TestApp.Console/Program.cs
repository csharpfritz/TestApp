using System;

namespace TestApp.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var i = 10;
            i++;
            System.Console.WriteLine(i);


        }

        public static int Sum(int addendOne, int addendTwo)
        {

            return addendOne + addendTwo;

        }


    }
}
