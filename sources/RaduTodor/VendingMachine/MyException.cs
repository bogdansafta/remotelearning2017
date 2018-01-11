using System;

namespace VendingMachine
{
    internal class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("A problem has occured");
        }

        public MyException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}