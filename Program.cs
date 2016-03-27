using System;
using NLog;
using NСlass_Properties;
using NInterface_and_Exception;
using NAnimals;
using System.Collections.Generic;

namespace Zoo
{
    static class Program
    {
        public static Logger log;
        static void Main(string[] args)
        {
            Flight flight = new Flight();
            Run run = new Run();
            Swimming swimming = new Swimming();
            Meow meow = new Meow();
            Сrack crack = new Сrack();
            Twitter twitter = new Twitter();
            List<IAnimal> list = new List<IAnimal>();
            list.Add(new Cat<Run, Twitter>());
            list.Add(new Herring<Swimming, Swimming>());
            list.Add(new Sparrow<Run, Twitter>());
            foreach (IAnimal rec in list)
            {
                try
                {
                    rec.Motion();
                }
                catch (BeingNotProperty ex)
                {
                    log = LogManager.GetCurrentClassLogger();
                    log.Error("У данного существа нет такого свойства!" + rec.GetType().ToString(), ex);
                }

                try
                {
                    rec.Vocalize();
                }
                catch (BeingNotProperty ex)
                {
                    log = LogManager.GetCurrentClassLogger();
                    log.Error("у данного существа нет такого свойства!" + rec.GetType().ToString(), ex);
                }
            }

            Console.ReadKey();
        }
    }
}
