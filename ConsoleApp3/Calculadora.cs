using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class Calculadora
    {
        public double Soma(List<double> nums)
        {
            Console.Clear();
            double total = 0;
            foreach (double num in nums)
            {
                total += num;
            }
            Console.WriteLine(total);
            Console.ReadLine();
            return total;
        }

        public double Subtracao(double total, double[] nums)
        {
            foreach (double num in nums)
            {
                total -= num;
            }
            return total;
        }

        public double Multiplicacao(params double[] nums)
        {
            double total = 0;
            foreach (double num in nums)
            {
                total += num;
            }
            return 0;
        }

        public double Divisao(params double[] nums)
        {
            double total = 0;
            foreach (double num in nums)
            {
                total += num;
            }
            return 0;
        }
    }
}