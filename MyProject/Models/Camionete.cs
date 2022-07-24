using static System.Console;

namespace Automovel.Models
{
    public class Camionete : Veiculo
    {
        public int portas;
        private string? combustivel;
        public string? Combustivel { get; set; }
        private int capacidadeDeCarga;
        public int CapacidadeDeCarga
        {
            get => capacidadeDeCarga;
            set => capacidadeDeCarga = value;
        }

        public Camionete()
        {
            portas = 4;
            Combustivel = Combustivel;
            CapacidadeDeCarga = CapacidadeDeCarga;
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

                WriteLine("\n ---- Camionete Vendida! ---- \n");
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {Placa}, CPF comprador {CPF}, Valor: {Valor} \n");
                ResetColor();
            }
        }
    }
}
