// See https://aka.ms/new-console-template for more information
using System;

namespace std
{
    public class overloading
    {
        public static void Main(string[] args)
        {
            overloading add = new overloading();
            add.Math(1, 2);
            add.Math(1, 2, 3);
            Console.ReadLine();
        }

        public void Math(int a, int b)
        {
            Console.WriteLine("The addition of two numbers are: " + a + b);
        }
        public void Math(int a, int b, int c)
        {
            Console.WriteLine("The addition of two numbers are: " + a + b + c);
        }
    }
}