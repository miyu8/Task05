using System;
using NLog;
using NСlass_Properties;
using NInterface_and_Exception;
using NAnimals;

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
            Cat cat = new Cat();
            Sparrow sparrow = new Sparrow();
            Herring herring = new Herring();

            try
            {
                cat.Motion(flight);
            }
            catch (BeingNotProperty ex)
            {
                log = LogManager.GetCurrentClassLogger();
                log.Error("У данного существа нет такого свойства!", ex);
            }

            try
            {
                cat.Motion(run);
            }
            catch (BeingNotProperty ex)
            {
                log = LogManager.GetCurrentClassLogger();
                log.Error("У данного существа нет такого свойства!", ex);
            }

            try
            {
                cat.Motion(swimming);
            }
            catch (BeingNotProperty ex)
            {
                log = LogManager.GetCurrentClassLogger();
                log.Error("У данного существа нет такого свойства!", ex);
            }

            try
            {
                sparrow.Motion(flight);
            }
            catch (BeingNotProperty ex)
            {
                log = LogManager.GetCurrentClassLogger();
                log.Error("У данного существа нет такого свойства!", ex);
            }

            try
            {
                sparrow.Motion(run);
            }
            catch (BeingNotProperty ex)
            {
                log = LogManager.GetCurrentClassLogger();
                log.Error("У данного существа нет такого свойства!", ex);
            }

            try
            {
                sparrow.Motion(swimming);
            }
            catch (BeingNotProperty ex)
            {
                log = LogManager.GetCurrentClassLogger();
                log.Error("У данного существа нет такого свойства!", ex);
            }

            try
            {
                herring.Motion(flight);
            }
            catch (BeingNotProperty ex)
            {
                log = LogManager.GetCurrentClassLogger();
                log.Error("У данного существа нет такого свойства!", ex);
            }

            try
            {
                herring.Motion(run);
            }
            catch (BeingNotProperty ex)
            {
                log = LogManager.GetCurrentClassLogger();
                log.Error("У данного существа нет такого свойства!", ex);
            }

            try
            {
                herring.Motion(swimming);
            }
            catch (BeingNotProperty ex)
            {
                log = LogManager.GetCurrentClassLogger();
                log.Error("У данного существа нет такого свойства!", ex);
            }

            Console.ReadKey();
        }
    }
}
