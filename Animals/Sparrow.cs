using System;
using NСlass_Properties;
using NInterface_and_Exception;

namespace NAnimals
{
    public class Sparrow<T1, T2> : IAnimal//<T1, T2>
        where T1 : new()
        where T2 : new()
    {
        public T1 t1 = new T1();
        public T2 t2 = new T2();

        public void Motion()
        {
            if (t1 is Flight)
                Console.WriteLine("Я воробей, я летаю!!!");
            else
                throw new BeingNotProperty();
        }

        public void Vocalize()
        {
            if (t2 is Twitter)
                Console.WriteLine("Я воробей, я щебечу!!!");
            else
                throw new BeingNotProperty();
        }
    }
}
