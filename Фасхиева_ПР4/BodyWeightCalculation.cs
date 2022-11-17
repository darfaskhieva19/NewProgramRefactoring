using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фасхиева_ПР3
{
    internal class BodyWeightCalculation
    {
        private double height; //рост
        private double weight; //вес

        public double getWeight
        {
            set
            {
                weight = value;
            }
        }
        public double getHeight
        {
            set
            {
                height = value;
            }
        }
        public string bodyWeight // масса тела
        {
            get
            {
                //Подсчет массы тела
                double mas = weight / (Math.Pow(height / 100, 2));
                if (mas <= 18.5)
                {
                    return "Дефицит массы тела";
                }
                else if (mas > 18.5 && mas < 25)
                {
                    return "Норма";
                }
                else
                {
                    return "Избыточная массa тела";
                }
            }
        }
    }
}
