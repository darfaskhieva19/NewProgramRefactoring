using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фасхиева_ПР3
{
    internal class ActionAChar //изменено название класса
    {
        public static string txt;
        public static void DeletALineOfProccess(int numberDelete) //Изменено название метода на более понятное
        {
            try
            {
                txt = txt.Remove(numberDelete);
                Console.WriteLine($"Измененная строка: {txt}"); //Вывод измененной строки
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение -> {ex.Message}");
            }
        }
    }
}
