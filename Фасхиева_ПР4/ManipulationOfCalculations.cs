using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фасхиева_ПР3
{
    internal class ManipulationOfCalculations
    {
        string symbol;
        char line;
        public ManipulationOfCalculations(string symb, char lines)
        {
            try
            {
                this.symbol = symb;
                this.line = lines;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Исключение -> {ex.Message}");
            }
        }
        public static int operator +(ManipulationOfCalculations a, ManipulationOfCalculations b)
        {
            return a.symbol.Length + b.symbol.Length;
        }
        public static string operator -(ManipulationOfCalculations a, ManipulationOfCalculations b)
        {
            int k = (int)a.line - (int)b.line;
            if (k < 0)
            {
                return "Разность отрицательная";
            }
            else
            {
                return Convert.ToString((char)k);
            }
        }
    }
}
