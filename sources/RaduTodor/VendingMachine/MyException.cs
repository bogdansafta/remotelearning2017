using System;

namespace VendingMachine
{
    internal class MyException : Exception
    {
        public String Problem;

        public MyException()
        {
            Console.WriteLine("A problem has occured");
        }

        public MyException(string message) : base(message)
        {
            Problem=message;
        }
    }
}