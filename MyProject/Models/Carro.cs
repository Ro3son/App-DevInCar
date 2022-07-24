using static System.Console;

namespace Automovel.Models
{
    public class Carro : Veiculo
    {
        public int portas;
        private string? combustivel;
        public string? Combustivel { get; set; }

        public Carro()
        {
            portas = 4;
            Combustivel = Combustivel;
            CPF = CPF;
            Valor = Valor;
            Placa = Placa;
        }

        public override void VenderVeiculos()
        {
            WriteLine("Deseja vender o veículo disponível? (s/n)");

            var input = ReadLine();
            WriteLine("\n");

            if (input == "s")
            {
                WriteLine("Digite o ID(placa) do veículo: ");
                Placa = ReadLine();
                WriteLine("\n");

                WriteLine("Digite o CPF(somente números) do comprador: ");
                CPF = ReadLine();
                WriteLine("\n");

                WriteLine("Digite o valor do veículo: ");
                Valor = Convert.ToDecimal(ReadLine());
                WriteLine("\n");

                WriteLine("\n ---- Carro Vendido! ---- \n");
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {Placa}, CPF comprador {CPF}, Valor: {Valor} \n");
                ResetColor();
            }
        }
    }
}
