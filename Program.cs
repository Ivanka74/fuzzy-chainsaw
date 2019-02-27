using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Wires
    {
        public string Brand;
        public double SectionArea;
        public double SpecificActiveReasistance;
        public string Material;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var FirstWire = new Wires();
            {
                FirstWire.Brand = "AC";
                FirstWire.SectionArea = 13.5;
                FirstWire.SpecificActiveReasistance = 0.78;
                FirstWire.Material = "алюміній";
            }
            Console.WriteLine("Марка: {0}\nПлоща перерізу: {1} мм\nПитомий активний опір: {2}" +
                " Ом\nМатеріал: {3}", FirstWire.Brand, FirstWire.SectionArea, FirstWire.SpecificActiveReasistance, FirstWire.Material);
            Console.WriteLine();
            var SecondWire = new Wires();
            {
                SecondWire.Brand = "СИП";
                SecondWire.SectionArea = 16;
                SecondWire.SpecificActiveReasistance = 0.95;
                SecondWire.Material = "алюміній";
            }
            Console.WriteLine("Марка: {0}\nПлоща перерізу: {1} мм\nПитомий активний опір: {2}" +
                " Ом\nМатеріал: {3}", SecondWire.Brand, SecondWire.SectionArea, SecondWire.SpecificActiveReasistance, SecondWire.Material);
            Console.WriteLine();
            var ThirdWire = new Wires();
            {
                ThirdWire.Brand = "САПт";
                ThirdWire.SectionArea = 16;
                ThirdWire.SpecificActiveReasistance = 0.87;
                ThirdWire.Material = "алюміній";
            }
            Console.WriteLine("Марка: {0}\nПлоща перерізу: {1} мм\nПитомий активний опір: {2}" +
                " Ом\nМатеріал: {3}", ThirdWire.Brand, ThirdWire.SectionArea, ThirdWire.SpecificActiveReasistance, ThirdWire.Material);
            Console.ReadLine();
        }
    }
}
