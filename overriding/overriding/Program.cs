// See https://aka.ms/new-console-template for more information
using System;

namespace std
{
    public class A
    {
        public static void Main(string[] args)
        {

            dog dog = new dog();
            dog.Speak();

            cat cat = new cat();
            cat.Speak();

            Console.ReadLine();
        }

         public abstract class animal
        {
            public abstract void Speak();
           
        }

        public class dog : animal
        {
            public override void Speak()
            {
                Console.WriteLine("dog does bhau bhau ");
            }
        }

        public class cat : animal
        {
            public override void Speak()
            {
                Console.WriteLine("cat does meow meow ");
            }
        }

    }
}
