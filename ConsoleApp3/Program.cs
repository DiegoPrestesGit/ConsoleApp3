using System;

namespace Projeto
{  
    class Program
    { 
        public static void Main(String[] args)
        {
            Execute();

            Console.Read();
        }

        public static void Execute()
        {
            Calculadora calc = new Calculadora();
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("DIGITE A OPERAÇÃO QUE DESEJA FAZER:");
                Console.WriteLine("SOMA                            [1]");
                Console.WriteLine("SUBTRACAO                       [2]");
                Console.WriteLine("MULTIPLICACAO                   [3]");
                Console.WriteLine("DIVISAO                         [4]");
                int operacao = int.Parse(Console.ReadLine());

                switch (operacao){
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }

}