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
                new Moto("CHASSI12454T4T456", "PLC1234", "CG 160 Titan", 2022, 15.1, "Cinza", 14.620m, EOpcao.Moto));
            veiculos.Add(
                new Moto("CHASSI123DFGEVGBU", "BRA2S5D", "CG 160 Fan", 2017, 15.1, "Azul", 13.480m, EOpcao.Moto));
            veiculos.Add(
                new Moto("CHASSIQER234GYHJC", "CBA3S5K", "CG 160 Cargo", 2021, 15.1, "Branco", 13.650m, EOpcao.Moto));
            veiculos.Add(
                new Moto("CHASSIYUIH78VR67J", "SPA1SL3", "CG 160 Start", 2019, 15.1, "Prata", 12.280m, EOpcao.Moto));

            veiculos.Add(
                new Triciclo("CHASSI123AZXSDCFE4", "TRI1237", "Tricity 300", 2022, 20.6, "Azul", 48.605m, EOpcao.Triciclo));
            veiculos.Add(
                new Triciclo("CHASSI678GTUHJKXOL", "CITY123", "Tricity 125", 2022, 9.0, "Azul", 24.009m, EOpcao.Triciclo));
            
            veiculos.Add(
                new Carro("CHASSIGHJOLNQSED4", "CAR3XFV", "Fiat Uno", 2019, 75.0, "Vermelho", 43.807m, EOpcao.Carro));

            while (true)
            {
                var entrada = Convert.ToInt32(ReadLine());

                EOpcao options = (EOpcao)entrada;

                switch (options)
                {
                    case EOpcao.Moto:

                        WriteLine($"\n ---- Motos Disponíveis ---- \n");

                        var motos =
                            from veiculo in veiculos
                            where veiculo.Tipo == EOpcao.Moto
                            select veiculo;

                        foreach (Moto moto in motos)
                        {
                            ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLine(
                                $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo} Rodas: {moto.rodas}\n"
                                    + $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                            );
                            ResetColor();

                            moto.VenderVeiculos();
                        }

                        WriteLine("\n ---- Motos com o maior valor ---- \n");

                        var motosMaiorPreco = veiculos
                            .Where(veiculo => (veiculo.Tipo == EOpcao.Moto))
                            .Where(veiculo => veiculo.Valor >= 13.500m);

                        foreach (Moto moto in motosMaiorPreco)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                                $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo} Rodas: {moto.rodas}\n"
                                    + $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                            );
                            ResetColor();
                        }

                        WriteLine("\n ---- Motos com o menor valor ---- \n");

                        var motosMenorPreco = veiculos
                            .Where(veiculo => (veiculo.Tipo == EOpcao.Moto))
                            .Where(veiculo => veiculo.Valor <= 13.500m);

                        foreach (Moto moto in motosMenorPreco)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                                $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo} Rodas: {moto.rodas}\n"
                                    + $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                            );
                            ResetColor();
                        }
                    break;

                    case EOpcao.Triciclo:

                        WriteLine($"\n ---- Triciclos Disponíveis ---- \n");

                        var triciclos =
                            from veiculo in veiculos
                            where veiculo.Tipo == EOpcao.Triciclo
                            select veiculo;

                        foreach (Triciclo triciclo in triciclos)
                        {
                            ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLine(
                                $"Chassi: {triciclo.NumeroChassi}, Placa: {triciclo.Placa}, Modelo: {triciclo.NomeModelo} Rodas: {triciclo.rodas}\n"
                                    + $"Potência: {triciclo.Potencia} (kw), Ano: {triciclo.DataFabricacao}, Cor: {triciclo.Cor}, Preço: {triciclo.Valor}\n"
                            );
                            ResetColor();

                            triciclo.VenderVeiculos();
                        }

                        WriteLine("\n ---- Triciclo com o maior valor ---- \n");

                        var tricicloMaiorPreco = veiculos
                            .Where(veiculo => (veiculo.Tipo == EOpcao.Triciclo))
                            .Where(veiculo => veiculo.Valor >= 25.500m);

                        foreach (Triciclo triciclo in tricicloMaiorPreco)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                                $"Chassi: {triciclo.NumeroChassi}, Placa: {triciclo.Placa}, Modelo: {triciclo.NomeModelo} Rodas: {triciclo.rodas}\n"
                                    + $"Potência: {triciclo.Potencia} (kw), Ano: {triciclo.DataFabricacao}, Cor: {triciclo.Cor}, Preço: {triciclo.Valor}\n"
                            );
                            ResetColor();
                        }

                        WriteLine("\n ---- Triciclo com o menor valor ---- \n");

                        var tricicloMenorPreco = veiculos
                            .Where(veiculo => (veiculo.Tipo == EOpcao.Triciclo))
                            .Where(veiculo => veiculo.Valor <= 25.500m);

                        foreach (Triciclo triciclo in tricicloMenorPreco)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                                $"Chassi: {triciclo.NumeroChassi}, Placa: {triciclo.Placa}, Modelo: {triciclo.NomeModelo} Rodas: {triciclo.rodas}\n"
                                    + $"Potência: {triciclo.Potencia} (cv), Ano: {triciclo.DataFabricacao}, Cor: {triciclo.Cor}, Preço: {triciclo.Valor}\n"
                            );
                            ResetColor();
                        }
                    break;
                }
            }
        }
    }
}
