using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.PrintName();
        }
        /// <summary>
        /// it is a method 
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("merge in the main branch");
        }
    }
}
