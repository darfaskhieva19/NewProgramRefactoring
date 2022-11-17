using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фасхиева_ПР3
{
    internal class NumbersManipul //Изменено название класса на более понятное
    {
        private int number; //изменение названия переменной

        public NumbersManipul(int num)
        {
            try
            {
                this.number = num % 10;
            }
           catch(Exception ex)
            {
                Console.WriteLine($"Исключение -> {ex.Message}");
            }
        }
        public NumbersManipul()
        {
            try
            {
                number = -1;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Исключение -> {ex.Message}");
            }
        }
        public override string ToString() //вывод значения числа
        {
            return "Значение целочисленного поля: " + number;
        }
    }
}
