using System;
using NInterface_and_Exception;

namespace NСlass_Properties
{
    public class Run : IMotion<Run>
    {
        public void Motion()
        {
            Console.WriteLine("я бегаю");
        }
    }
}
