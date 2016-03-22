using System;
using NСlass_Properties;
using NInterface_and_Exception;

namespace NAnimals
{
    public class Sparrow
    {
        public void Motion(object play)
        {
            if (play is Flight)
                Console.WriteLine("Я воробей, я летаю!!!");
            else
                throw new BeingNotProperty();
        }

        public void Vocalize(object cry)
        {
            if (cry is Twitter)
                Console.WriteLine("Я воробей, я щебечу!!!");
            else
                throw new BeingNotProperty();
        }
    }
}
