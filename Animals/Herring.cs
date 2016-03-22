using System;
using NСlass_Properties;
using NInterface_and_Exception;

namespace NAnimals
{
    public class Herring
    {
        public void Motion(object play)
        {
            if (play is Swimming)
                Console.WriteLine("Я сельдь, я плаваю!!!");
            else
                throw new BeingNotProperty();
        }

        public void Vocalize(object cry)
        {
            if (cry is Сrack)
                Console.WriteLine("Я сельдь, я трещу!!!");
            else
                throw new BeingNotProperty();
        }
    }
}
