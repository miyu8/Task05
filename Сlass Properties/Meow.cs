using System;
using NInterface_and_Exception;

namespace NСlass_Properties
{
    public class Meow : IVocalize
    {
        public void Vocalize()
        {
            Console.WriteLine("я мяукаю");
        }
    }
}
