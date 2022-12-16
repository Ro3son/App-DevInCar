using static System.Console;

namespace Automovel.Models
{
    public abstract class Veiculo
    {
        public string? NumeroChassi { get; set; }
        public string? Placa { get; set; }
        public string? NomeModelo { get; set; }
        public int DataFabricacao { get; set; }
        public double Potencia { get; set; }
        public string? Cor { get; set; }
        public decimal Valor { get; set; }
        public string? CPF { get; set; }
        public EMenu Tipo { get; set; }
        public EStatus Status { get; set; }

        public Veiculo() { }

        public abstract void VenderVeiculos();

        public List<Veiculo> veiculos = new();

        public virtual List<Veiculo> ListarVeiculos()
        {
            return veiculos;
        }

        public static void EditarInformacoes() { }

        public static void Menu()
        {
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine(
                "1 - Motos, "
                    + "2 - Triciclos, "
                    + "3 - Carros, "
                    + "4 - Camionetes, "
                    + "5 - Todos, "
                    + "6 - Histórico, "
                    + "0 - Sair\n"
            );
            ResetColor();
        }
    }
}
