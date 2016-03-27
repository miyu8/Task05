using System;
using NСlass_Properties;
using NInterface_and_Exception;

namespace NAnimals
{
    public class Cat<T1, T2> : IAnimal
        where T1 : new()
        where T2 : new()
    {
        public T1 t1 = new T1();
        public T2 t2 = new T2();

        public void Motion()
        {
            if (t1 is Run)
                Console.WriteLine("Я кошка, я бегаю!!!");
            else
                throw new BeingNotProperty();
        }

        public void Vocalize()
        {
            if (t2 is Meow)
                Console.WriteLine("Я кошка, я мяукаю!!!");
            else
                throw new BeingNotProperty();
        }
    }
}
