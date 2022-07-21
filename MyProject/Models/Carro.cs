using static System.Console;

namespace Automovel.Models
{
    public class Carro : Veiculo
    {   
        public int portas = 4;
        private string combustivel;
        public string Combustivel { 

            get => combustivel; 
            set => combustivel = value;
        }
        public Carro(
            string chassi,
            string placa,
            string modelo,
            int data,
            double potencia,
            string cor,
            decimal valor,
            string combustivel,
            EOpcao tipo
        ) : base(chassi, placa, modelo, data, potencia, cor, valor, tipo) 
        { 
            Combustivel = combustivel; 
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

                WriteLine("\n ---- Carro Vendido! ---- \n");
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {id}, CPF comprador {cpf}, Valor: {valor} \n");
                ResetColor();
            }
        }
    }
}
