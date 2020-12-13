namespace Projeto
{
    public class Calculadora
    {
        public double Soma(params double[] nums)
        {
            double total = 0;
            foreach (double num in nums)
            {
                total += num;
            }
            return total;
        }

        public double Subtracao(double total, params double[] nums)
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