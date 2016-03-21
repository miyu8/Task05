using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

public interface IBeing
{
    void Motion(string play);
    void Vocalize(string cry);
}

public class Cat : IBeing
{
    public void Motion(string play)
    {
        if (play == "бегать")
            Console.WriteLine(play);
        else
        {
            Console.WriteLine("Кошка не может {0}", play);
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Error("{0} - неправильно указано действие", play);
        }
    }

    public void Vocalize(string cry)
    {
        if (cry == "мяукать")
            Console.WriteLine(cry);
        else
        {
            Console.WriteLine("Кошка не может {0}", cry);
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Error("{0} - неправильно указан звук", cry);
        }
    }
}

public class Sparrow : IBeing
{
    public void Motion(string play)
    {
        if (play == "летать")
            Console.WriteLine(play);
        else
        {
            Console.WriteLine("Воробей не может {0}", play);
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Error("{0} - неправильно указано действие", play);
        }
    }
    public void Vocalize(string cry)
    {
        if (cry == "щебетать")
            Console.WriteLine(cry);
        else
        {
            Console.WriteLine("Воробей не может {0}", cry);
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Error("{0} - неправильно указан звук", cry);
        }
    }
}

public class Herring : IBeing
{
    public void Motion(string play)
    {
        if (play == "плавать")
            Console.WriteLine(play);
        else
        {
            Console.WriteLine("Сельдь не может {0}", play);
            ILogger logger = LogManager.GetCurrentClassLogger();
            logger.Error("{0} - неправильно указано действие", play);
        }
    }

    public void Vocalize(string cry)
    {
        if (cry == "трещать")
            Console.WriteLine(cry);
        else
        {
            Console.WriteLine("Сельдь не может {0}", cry);
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Error("{0} - неправильно указан звук", cry);
        }
    }
}

namespace Zoo
{
    static class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Motion("бегать");
            cat.Motion("летать");
            cat.Vocalize("мяукать");
            cat.Vocalize("трещать");
            Sparrow sparrow = new Sparrow();
            sparrow.Motion("летать");
            sparrow.Motion("плавать");
            sparrow.Vocalize("щебетать");
            sparrow.Vocalize("мяукать");
            Herring herring = new Herring();
            herring.Motion("плавать");
            herring.Motion("бегать");
            herring.Vocalize("трещать");
            herring.Vocalize("щебетать");
            Console.ReadKey();
        }
    }
}
