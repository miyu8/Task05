using System;
using NInterface_and_Exception;

namespace NСlass_Properties
{
    public class Twitter : IVocalize<Twitter>
    {
        public void Vocalize()
        {
            Console.WriteLine("я щебечу");
        }
    }
}
