using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CalculadoraView
    {
        public Calculadora Calculadora { get; set; }
        public void MainMenu()
        {
            Calculadora = new Calculadora();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("DIGITE A OPERAÇÃO QUE DESEJA FAZER:");
                Console.WriteLine("SOMA                            [1]");
                Console.WriteLine("SUBTRACAO                       [2]");
                Console.WriteLine("MULTIPLICACAO                   [3]");
                Console.WriteLine("DIVISAO                         [4]");
                Console.WriteLine("SAIR DA CALCULADORA             [0]");
                int operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 1:
                        MenuSoma();
                        break;

                    case 2:
                        MenuSubtracao();
                        break;

                    case 3:
                        MenuMultiplicacao();
                        break;

                    case 4:
                        MenuDivisao();
                        break;

                    case 0:
                        flag = false;
                        Console.WriteLine("OBRIGADO PELA PREFERÊNCIA E VOLTE SEMPRE!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }

        public void MenuSoma()
        {
            Console.Clear();
            Console.WriteLine("BEM VINDO AO MENU DE SOMA!");
            Console.WriteLine("Quanto números irá somar?");
            int qntSoma = int.Parse(Console.ReadLine());
            List<double> nums = new List<double>();
            for (int i = 1; i <= qntSoma; i++)
            {
                Console.WriteLine($"Digite o {i}º número a ser somado:");
                nums.Add(double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            Calculadora.Soma(nums);
        }

        public void MenuSubtracao()
        {

        }

        public void MenuMultiplicacao()
        {

        }

        public void MenuDivisao()
        {

        }
    }
}
