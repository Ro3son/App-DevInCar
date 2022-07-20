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
            List<Veiculo> veiculos = new List<Veiculo>();

            veiculos.Add(
                new Moto("CHASSI12454T4T456", "PLC1234", "CG 160 Titan", 2022, 15.1, "Cinza", 14.620m,ETipo.Moto));
            veiculos.Add(
                new Moto("CHASSI123DFGEVGBU", "BRA2S5D", "CG 160 Fan", 2017, 15.1, "Azul", 13.480m, ETipo.Moto));
            veiculos.Add(
                new Moto("CHASSIQER234GYHJC", "CBA3S5K", "CG 160 Cargo", 2021, 15.1, "Branco", 13.650m, ETipo.Moto));
            veiculos.Add(
                new Moto("CHASSIYUIH78VR67J", "SPA1SL3", "CG 160 Start", 2019, 15.1, "Prata", 12.280m, ETipo.Moto));

            while (true)
            {
                var entrada = Convert.ToInt32(ReadLine());

                ETipo options = (ETipo)entrada;

                switch (options)
                {
                    case ETipo.Moto:

                        WriteLine($"\n ---- Motos Disponíveis({veiculos.Count()}) ---- \n");

                        var motos =
                            from veiculo in veiculos
                            where veiculo.Tipo == ETipo.Moto
                            select veiculo;


                        foreach (Moto moto in motos)
                        {   

                            ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLine(
                                $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo} Rodas: {moto.rodas}\n" +
                                $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                            );
                            ResetColor();

                            moto.VenderVeiculos();
                
                        }
                        
                        // foreach(Moto moto in motos) 
                        // {
                        //     // Jogar no Histórico de Vendas?
                        //     if (moto.Valor >= 13.000m)
                        //     {
                        //         WriteLine("\n ---- Motos com o maior preço ---- \n");
                        //         ForegroundColor = ConsoleColor.DarkYellow;
                        //         WriteLine(
                        //             $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo} Rodas: {moto.rodas}\n"
                        //                 + $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                        //         );
                        //         ResetColor();
                        //     }
                        //     else
                        //     {
                        //         WriteLine("\n ---- Motos com menor preço ---- \n");
                        //         ForegroundColor = ConsoleColor.DarkYellow;
                        //         WriteLine(
                        //             $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo} Rodas: {moto.rodas}\n"
                        //                 + $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                        //             );
                        //         ResetColor();
                        //     }
                        // }

                    break;
                }
            }
        }
    }
}
