using System;
using NInterface_and_Exception;

namespace NСlass_Properties
{
    public class Swimming : IMotion<Swimming>
    {
        public void Motion()
        {
            Console.WriteLine("я плаваю");
        }
    }
}
