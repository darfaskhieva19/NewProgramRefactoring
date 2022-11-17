using System;

namespace Фасхиева_ПР3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача №1");
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            NumbersManipul obj = new NumbersManipul(n);
            Console.WriteLine(obj);
            NumbersManipul obj1 = new NumbersManipul();
            Console.WriteLine(obj1);
            Console.WriteLine();

            Console.WriteLine("Задача №2");
            Console.WriteLine("Введите строку: ");
            ActionAChar.txt = Console.ReadLine();
            Console.WriteLine("Введите индекс: ");
            int k = Convert.ToInt32(Console.ReadLine());
            ActionAChar.DeletALineOfProccess(k);
            Console.WriteLine();

            Console.WriteLine("Задача №4");
            BodyWeightCalculation ind = new BodyWeightCalculation();
            Console.WriteLine("Введите рост: ");
            ind.getHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес: ");
            ind.getWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ind.bodyWeight);
            Console.WriteLine();

            Console.WriteLine("Задача №3");
            Console.WriteLine("Введите первую строку: ");
            string st = Console.ReadLine();
            Console.WriteLine("Введите первый символ: ");
            char s = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите вторую строку: ");
            string st2 = Console.ReadLine();
            Console.WriteLine("Введите второй символ: ");
            char s2 = Convert.ToChar(Console.ReadLine());
            ManipulationOfCalculations l = new ManipulationOfCalculations(st, s);
            ManipulationOfCalculations l1 = new ManipulationOfCalculations(st2, s2);
            Console.WriteLine(l + l1);
            Console.WriteLine(l - l1);
        }
    }
}