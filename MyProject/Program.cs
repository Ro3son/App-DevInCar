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
                        Moto moto = new();
                        moto.ListarVeiculos();
                        moto.VenderVeiculos();
                        Veiculo.EditarInformacoes();
                        Veiculo.Menu();
                    break;

                    case EMenu.Triciclo:
                        Triciclo triciclo = new();
                        triciclo.ListarVeiculos();
                        triciclo.VenderVeiculos();
                        Veiculo.EditarInformacoes();
                        Veiculo.Menu();
                    break;

                    case EMenu.Carro:
                        Carro carro = new();
                        carro.ListarVeiculos();
                        carro.VenderVeiculos();
                        Veiculo.EditarInformacoes();
                        Veiculo.Menu();
                    break;

                    case EMenu.Camionete:
                        Camionete camionete = new();
                        camionete.ListarVeiculos();
                        camionete.VenderVeiculos();
                        Veiculo.EditarInformacoes();
                        Veiculo.Menu();
                    break;

                    case EMenu.Todos:
                        Lista lista = new();
                        lista.ListarTodos();
                    break;

                    case EMenu.Historico:
                        WriteLine("\n ---- Histórico de Vendas ---- \n");
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
