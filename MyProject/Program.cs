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
                new Carro("CHASSIGHJOLNQSED4", "CAR3XFV", "Fiat Uno", 2019, 75.0, "Vermelho", 43.807m, "Flex", EOpcao.Carro ));
            veiculos.Add(
                new Carro("CHASSIRFV567IJNSW", "3XFVPCO", "VW Gol", 2018, 82.0, "Preto", 47.454m, "Gasolina", EOpcao.Carro));
            veiculos.Add(
                new Carro("CHASSIOLXSEM2F4F7", "FVCAR37", "Renault Duster", 2017, 118.0, "Branco", 67.920m, "Flex", EOpcao.Carro));
            veiculos.Add(
                new Carro("CHASSIZXC567NJIK8", "BAA1234", "Chevrolet Onix", 2019, 78.0, "Vermelho", 53.345m, "Gasolina", EOpcao.Carro));

            veiculos.Add( 
                new Camionete("CHASSIFA3DVFOLM1D7", "PLCAR34", "Fiat Toro", 2021, 139.0, "Roxo", 103.394m, "Diesel", 820, EOpcao.Camionete));
            veiculos.Add( 
                new Camionete("CHASSIYUI789O50HL", "TYT678X", "Toyota Hilux", 2022, 204.0, "Roxo", 238.090m, "Diesel", 910, EOpcao.Camionete));
            veiculos.Add( 
                new Camionete("CHASSL3ADFTTH7OGH", "CHVR3FL", "Chevrolet s10", 2018, 206.0, "Roxo", 113.692m, "Gasolina", 850, EOpcao.Camionete));

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

                        WriteLine("\n ---- Triciclos com o maior valor ---- \n");

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

                        WriteLine("\n ---- Triciclos com o menor valor ---- \n");

                        var tricicloMenorPreco = veiculos
                            .Where(veiculo => (veiculo.Tipo == EOpcao.Triciclo))
                            .Where(veiculo => veiculo.Valor <= 25.500m);

                        foreach (Triciclo triciclo in tricicloMenorPreco)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                                $"Chassi: {triciclo.NumeroChassi}, Placa: {triciclo.Placa}, Modelo: {triciclo.NomeModelo} Rodas: {triciclo.rodas}\n"
                                    + $"Potência: {triciclo.Potencia} (kw), Ano: {triciclo.DataFabricacao}, Cor: {triciclo.Cor}, Preço: {triciclo.Valor}\n"
                            );
                            ResetColor();
                        }
                    break;

                    case EOpcao.Carro:

                        WriteLine($"\n ---- Carros Disponíveis ---- \n");

                        var carros =
                            from veiculo in veiculos
                            where veiculo.Tipo == EOpcao.Carro
                            select veiculo;

                        foreach (Carro carro in carros)
                        {
                            ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLine(
                                $"Chassi: {carro.NumeroChassi}, Placa: {carro.Placa}, Modelo: {carro.NomeModelo}\n" +
                                $"Ano: {carro.DataFabricacao}, Cor: {carro.Cor}, Portas: {carro.Portas}\n" +
                                $"Potência: {carro.Potencia} (cv), Combustível: {carro.Combustivel}, Preço: {carro.Valor}\n"
                            );
                            ResetColor();

                            carro.VenderVeiculos();
                        }

                        WriteLine("\n ---- Carros com o maior valor ---- \n");

                        var carroMaiorPreco = veiculos
                            .Where(veiculo => (veiculo.Tipo == EOpcao.Carro))
                            .Where(veiculo => veiculo.Valor >= 50.000m);

                        foreach (Carro carro in carroMaiorPreco)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                                $"Chassi: {carro.NumeroChassi}, Placa: {carro.Placa}, Modelo: {carro.NomeModelo}\n" +
                                $"Ano: {carro.DataFabricacao}, Cor: {carro.Cor}, Portas: {carro.Portas}\n" +
                                $"Potência: {carro.Potencia} (cv), Combustível: {carro.Combustivel}, Preço: {carro.Valor}\n"
                            );
                            ResetColor();
                        }

                        WriteLine("\n ---- Carros com o menor valor ---- \n");

                        var carroMenorPreco = veiculos
                            .Where(veiculo => (veiculo.Tipo == EOpcao.Carro))
                            .Where(veiculo => veiculo.Valor <= 50.000m);

                        foreach (Carro carro in carroMenorPreco)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                               $"Chassi: {carro.NumeroChassi}, Placa: {carro.Placa}, Modelo: {carro.NomeModelo}\n" +
                               $"Ano: {carro.DataFabricacao}, Cor: {carro.Cor}, Portas: {carro.Portas}\n" +
                               $"Potência: {carro.Potencia} (cv), Combustível: {carro.Combustivel}, Preço: {carro.Valor}\n"
                            );
                            ResetColor();
                        }
                    break;

                    case EOpcao.Camionete:

                        WriteLine($"\n ---- Camionetes Disponíveis ---- \n");

                        var camionetes =
                            from veiculo in veiculos
                            where veiculo.Tipo == EOpcao.Camionete
                            select veiculo;

                        foreach (Camionete camionete in camionetes)
                        {
                            ForegroundColor = ConsoleColor.DarkGreen;
                            WriteLine(
                                $"Chassi: {camionete.NumeroChassi}, Placa: {camionete.Placa}, Modelo: {camionete.NomeModelo}\n" +
                                $"Ano: {camionete.DataFabricacao}, Cor: {camionete.Cor}, Portas: {camionete.Portas}, Capacidade Caçamba: {camionete.CapacidadeDeCarga}(l)\n" +
                                $"Potência: {camionete.Potencia} (cv), Combustível: {camionete.Combustivel}, Preço: {camionete.Valor}\n"
                            );
                            ResetColor();

                            camionete.VenderVeiculos();
                        }

                        WriteLine("\n ---- Camionete com o maior valor ---- \n");

                        var camioneteMaiorPreco = veiculos
                            .Where(veiculo => (veiculo.Tipo == EOpcao.Camionete))
                            .Where(veiculo => veiculo.Valor >= 200.000m);

                        foreach (Camionete camionete in camioneteMaiorPreco)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                                $"Chassi: {camionete.NumeroChassi}, Placa: {camionete.Placa}, Modelo: {camionete.NomeModelo}\n" +
                                $"Ano: {camionete.DataFabricacao}, Cor: {camionete.Cor}, Portas: {camionete.Portas}, Capacidade Caçamba: {camionete.CapacidadeDeCarga}(l)\n" +
                                $"Potência: {camionete.Potencia} (cv), Combustível: {camionete.Combustivel}, Preço: {camionete.Valor}\n"
                            );
                            ResetColor();
                        }

                        WriteLine("\n ---- Camionete com o menor valor ---- \n");

                        var camioneteMenorPreco = veiculos
                            .Where(veiculo => (veiculo.Tipo == EOpcao.Camionete))
                            .Where(veiculo => veiculo.Valor <= 200.000m);

                        foreach (Camionete camionete in camioneteMenorPreco)
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                                $"Chassi: {camionete.NumeroChassi}, Placa: {camionete.Placa}, Modelo: {camionete.NomeModelo}\n" +
                                $"Ano: {camionete.DataFabricacao}, Cor: {camionete.Cor}, Portas: {camionete.Portas}, Capacidade Caçamba: {camionete.CapacidadeDeCarga}(l)\n" +
                                $"Potência: {camionete.Potencia}(cv), Combustível: {camionete.Combustivel}, Preço: {camionete.Valor}\n"
                            );
                            ResetColor();
                        }
                    break;
                    case EOpcao.Todos:

                        WriteLine("\n ---- Todos os veículos ---- \n");

                        foreach(Veiculo veiculo in veiculos) 
                        {
                            ForegroundColor = ConsoleColor.DarkYellow;
                            WriteLine(
                                $"Modelo {veiculo.NomeModelo}, Potência: {veiculo.Potencia}(cv)\n" +
                                $"Ano: {veiculo.DataFabricacao}, Cor: {veiculo.Cor}, Preço: {veiculo.Valor}\n"
                            );
                            ResetColor();
                        }
                    break;
                }
            }
        }
    }
}
