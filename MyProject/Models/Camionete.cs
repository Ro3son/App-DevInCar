using static System.Console;

namespace Automovel.Models
{
    public class Camionete : Veiculo
    {
        public int portas = 4;
        private string combustivel;
        private int capacidadeDeCarga;
        public int CapacidadeDeCarga
        {
            get => capacidadeDeCarga;
            set => capacidadeDeCarga = value;
        }
        public string Combustivel
        {
            get => combustivel;
            set => combustivel = value;
        }

        public Camionete(
            string chassi,
            string placa,
            string modelo,
            int data,
            double potencia,
            string cor,
            decimal valor,
            string combustivel,
            int carga,
            EOpcao tipo
        ) : base(chassi, placa, modelo, data, potencia, cor, valor, tipo)
        {
            Combustivel = combustivel;
            CapacidadeDeCarga = carga;
        }

        public override void VenderVeiculos()
        {
            WriteLine("Deseja vender o veículo disponível? (s/n)");

            var input = ReadLine();
            WriteLine("\n");

            if (input == "s")
            {
                WriteLine("Digite o ID(placa) do veículo: ");
                var id = ReadLine();
                WriteLine("\n");

                WriteLine("Digite o CPF(somente números) do comprador: ");
                var cpf = ReadLine();
                WriteLine("\n");

                WriteLine("Digite o valor do veículo: ");
                var valor = ReadLine();
                WriteLine("\n");

                WriteLine("\n ---- Camionete Vendida! ---- \n");
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {id}, CPF comprador {cpf}, Valor: {valor} \n");
                ResetColor();
            }
        }
    }
}
