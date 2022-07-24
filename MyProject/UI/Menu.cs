using static System.Console;

namespace Automovel.UI
{
    public static class Menu
    {
        public static void MostrarMenu()
        {   
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("\n ------ DEVInCar Veículos ------ \n");
            WriteLine("Informe um tipo de veículo: ");
            WriteLine(
                "1 - Motos\n" +
                "2 - Triciclos\n" +
                "3 - Carros\n" +
                "4 - Camionetes\n" +
                "5 - Todos\n"
            );
            WriteLine(
                "Outras opções: \n" +
                "6 - Histórico\n" +
                "0 - Sair\n"
            );
            ResetColor();
        }
    }
}
