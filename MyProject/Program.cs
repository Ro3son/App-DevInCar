using System;
using System.Collections.Generic;

namespace Automovel
{
    public class Program
    {
        static void Main()
        {   
           Menu();

           var condition = true;

            while (condition) {

                int option = Convert.ToInt32(Console.ReadLine());

                EMenu options = (EMenu)option;

                switch(options) {

                    case EMenu.Motos:

                        Console.WriteLine("\n ---- Motos Disponíveis ---- \n");

                        List<Moto> motos = new List<Moto>
                        {
                            new Moto("CHASSI12454T4T456", "PLC123","CG 160 Titan", 2021, 15.1, "Preto", 12.000m),
                            new Moto("CHASSI12454T4T456", "PLC123", "CG 160 Titan", 2020, 15.1, "Prata", 8.000m),
                        };

                        foreach (var moto in motos)
                        {
                            Console.WriteLine(
                                @$"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo},
                                Potência: {moto.Potencia} (cv),  Ano: {moto.DataFabricacao}, Cor: {moto.Cor},
                                Preço: {moto.Valor} "
                            );
                        }

                        Console.WriteLine("---- Motos Vendidas ----");
                        
                        Console.WriteLine("---- Motos vendidas com o maior preço ----");
                        
                        Console.WriteLine("---- Motos vendidas com menor preço ----");
                    break;
                }
            }
        }
        static void Menu() 
        {
            Console.WriteLine("\n ------ DEVInCar Veículos ------ \n");
            Console.WriteLine("Informe um tipo de veículo: ");
            Console.WriteLine("1 - Motos");
            Console.WriteLine("2 - Triciclo");
            Console.WriteLine("3 - Carros");
            Console.WriteLine("4 - Camionete");
            Console.WriteLine("5 - Todos");
            Console.WriteLine("0 - Sair");
        }
    }
}
