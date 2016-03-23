using System;
using NInterface_and_Exception;

namespace NСlass_Properties
{
    public class Meow : IVocalize<Meow>
    {
        public void Vocalize()
        {
            Console.WriteLine("я мяукаю");
        }
    }
}
