using System;


namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            bones Freind1 = new bones { Name = "Kaofang", Weight = 67 };
            bones Freind2 = new bones { Name = "Singto", Weight = 76 };
            bones Freind3 = new bones { Name = "Beem", Weight = 57 };
            bones Freind4 = new bones { Name = "Kan", Weight = 65 };
            bones Freind5 = new bones { Name = "Ta", Weight = 90 };
            int Allweight = (Freind1.Weight + Freind2.Weight + Freind3.Weight + Freind4.Weight + Freind5.Weight) / 5;
            Console.WriteLine(string.Format("the average weight of everyone: {0} Kg.", Allweight));
            Console.WriteLine(string.Format("the person who weighs the most: {0} heavy in {1} Kg.", Freind5.Name, Freind5.Weight));
            Console.WriteLine(string.Format("the person who weighs the least: {0} heavy in {1} Kg.", Freind3.Name, Freind3.Weight));
            Console.WriteLine("Software developer : Apiwat Daowkoksoong Stuednt Number: 643450093-9");
            Console.ReadKey();
        }
    }
}