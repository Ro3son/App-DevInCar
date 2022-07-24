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
                var entrada = Convert.ToInt32(ReadLine());

                EMenu options = (EMenu)entrada;

                switch (options)
                {
                    case EMenu.Moto:
                        Moto moto = new Moto();
                        moto.veiculos = moto.ListarVeiculos();
                        moto.VenderVeiculos();
                    break;

                    case EMenu.Triciclo:

                    break;

                    case EMenu.Carro:

                    break;

                    case EMenu.Camionete:

                    break;
                    case EMenu.Todos:

                    break;
                    case EMenu.Historico:

                        WriteLine("\n ---- Histórico de Vendas ---- \n");
                        Moto Honda = new Moto();
                        HistoricoVendas vendas = new HistoricoVendas(Honda);
                        WriteLine($"{vendas.Data}");
                        WriteLine(
                            $"Chassi: {vendas.DadosDoVeiculo.NumeroChassi}, Placa: {vendas.DadosDoVeiculo.Placa}\n"
                                + $"CPF: {vendas.CPFDoComprador}"
                        );
                    break;

                    case EMenu.Sair:
                        condition = false;
                        WriteLine("Saindo...");
                        break;
                    default:

                        WriteLine("Opção Inválida!");

                    break;
                }
            }
        }
    }
}
