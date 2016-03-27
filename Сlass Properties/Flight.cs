using System;
using NInterface_and_Exception;

namespace NСlass_Properties
{
    public class Flight : IMotion<Flight>
    {
        public void Motion()
        {
            Console.WriteLine("я летаю");
        }
    }
}
