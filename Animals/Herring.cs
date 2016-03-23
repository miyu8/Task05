using System;
using NСlass_Properties;
using NInterface_and_Exception;

namespace NAnimals
{
    public class Herring<T1, T2> : IAnimal
        where T1 : new()
        where T2 : new()
    {
        public T1 t1 = new T1();
        public T2 t2 = new T2();

        public void Motion()
        {
            if (t1 is Swimming)
                Console.WriteLine("Я сельдь, я плаваю!!!");
            else
                throw new BeingNotProperty();
        }

        public void Vocalize()
        {
            if (t2 is Сrack)
                Console.WriteLine("Я сельдь, я трещу!!!");
            else
                throw new BeingNotProperty();
        }
    }
}
