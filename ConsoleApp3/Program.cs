using System;

namespace ConsoleApp3
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
            CalculadoraView menuCalculadora = new CalculadoraView();
            menuCalculadora.MainMenu();
        }
    }

}