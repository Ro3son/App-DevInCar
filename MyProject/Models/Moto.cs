using static System.Console;

namespace Automovel.Models
{
    public class Moto : Veiculo
    {
        public int rodas = 2;
        public Moto(
            string chassi,
            string placa,
            string modelo,
            int data,
            double potencia,
            string cor,
            decimal valor
        ) : base(chassi, placa, modelo, data, potencia, cor, valor) { }

        public override void VenderVeiculos()
        {
            WriteLine("Deseja vender o veículo disponível? (s/n)");
            var entrada = ReadLine();
            if (entrada == "s")
            {
                WriteLine("Digite o ID(placa) do veículo: ");
                var id = ReadLine();
                WriteLine("Digite o CPF(somente números) do comprador: ");
                var cpf = ReadLine();
                WriteLine("Digite o valor do veículo: ");
                var valor = ReadLine();
                WriteLine("\n ---- Motos Vendidas ---- \n");
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {id}, CPF comprador {cpf}, Valor: {valor} \n");
                ResetColor();
            }
        }
    }
}
