using System;
using Automovel.UI;
using Automovel.Models;
using static System.Console;

namespace Automovel
{
    public class Program
    {
        static void Main()
        {
            Menu.MostrarMenu();
            ExecutarPrograma();
        }
        public static void ExecutarPrograma()
        {
            var condition = true;

            while (condition)
            {
                int option = Convert.ToInt32(Console.ReadLine());

                EMenu options = (EMenu)option;

                switch (options)
                {
                    case EMenu.Motos:

                        WriteLine("\n ---- Motos Disponíveis ---- \n");

                        List<Moto> motos = new List<Moto>
                        {
                            new Moto(
                                "CHASSI12454T4T456",
                                "PLC123",
                                "CG 160 Titan",
                                2021,
                                15.1,
                                "Preto",
                                12.000m
                            ),
                            new Moto(
                                "CHASSI12454T4T456",
                                "PLC123",
                                "CG 160 Titan",
                                2020,
                                15.1,
                                "Prata",
                                8.000m
                            ),
                        };

                        foreach (var moto in motos)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLine(
                                $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo}\n"
                                    + $"Potência: {moto.Potencia} (cv),  Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                            );
                            ResetColor();

                            moto.VenderVeiculos();
                        }

                        WriteLine("---- Motos vendidas com o maior preço ----");

                        WriteLine("---- Motos vendidas com menor preço ----");
                        break;
                }
            }
        }
    }
}
