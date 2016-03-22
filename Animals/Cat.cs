using System;
using NСlass_Properties;
using NInterface_and_Exception;

namespace NAnimals
{
    public class Cat
    {
        public void Motion(object play)
        {
            if (play is Run)
                Console.WriteLine("Я кошка, я бегаю!!!");
            else
                throw new BeingNotProperty();
        }

        public void Vocalize(object cry)
        {
            if (cry is Meow)
                Console.WriteLine("Я кошка, я мяукаю!!!");
            else
                throw new BeingNotProperty();
        }
    }
}
