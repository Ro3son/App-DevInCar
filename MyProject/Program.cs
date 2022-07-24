using System;
using System.Linq;
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
                        moto.Menu();
                        moto.EditarInformacoes();
                    break;

                    case EMenu.Triciclo:
                        Triciclo triciclo = new Triciclo();
                        triciclo.veiculos = triciclo.ListarVeiculos();
                        triciclo.VenderVeiculos();
                        triciclo.Menu();
                        triciclo.EditarInformacoes();
                    break;

                    case EMenu.Carro:
                        Carro carro = new Carro();
                        carro.veiculos = carro.ListarVeiculos();
                        carro.VenderVeiculos();
                        carro.Menu();
                        carro.EditarInformacoes();
                    break;

                    case EMenu.Camionete:
                        Camionete camionete = new Camionete();
                        camionete.veiculos = camionete.ListarVeiculos();
                        camionete.VenderVeiculos();
                        camionete.Menu();
                        camionete.EditarInformacoes();
                    break;

                    case EMenu.Todos:
                        Lista lista = new Lista();
                        lista.ListarTodos();
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
