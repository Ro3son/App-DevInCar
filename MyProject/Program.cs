using System;
using System.Collections.Generic;

namespace Automovel
{
    public class Program
    {
        static void Main()
        {
            // Console.WriteLine("\n ------ Menu ------ \n ");
            // Console.WriteLine("1 - Vendas");
            // Console.WriteLine("2 - Histórico");
            // Console.WriteLine("3 - Relatório");
            // Console.WriteLine("0 - Sair");
            // Console.ReadLine();

            // Moto Honda = new Moto(
            //     "CHASSI12454T4T456",
            //     "PLC123",
            //     "CG 160 Titan",
            //     2021,
            //     15.1,
            //     "Preto",
            //     12.000m
            // );

            // Console.WriteLine(
            // @$"Chassi: {Honda.NumeroChassi}, Placa: {Honda.Placa}, Modelo: {Honda.NomeModelo},
            // Potência: {Honda.Potencia} (cv),  Ano: {Honda.DataFabricacao}, Cor: {Honda.Cor},
            // Preço: {Honda.Valor}, Rodas: {Honda.rodas}"
            // );

            // Honda.VenderVeiculos();

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
                Console.WriteLine(
                    @$"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo},
                    Potência: {moto.Potencia} (cv),  Ano: {moto.DataFabricacao}, Cor: {moto.Cor},
                    Preço: {moto.Valor} "
                );
            }
        }
    }
}
