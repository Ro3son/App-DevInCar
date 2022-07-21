using static System.Console;

namespace Automovel.Models
{
    public class Moto : Veiculo
    {   
        public string brand = "Honda";
        public int rodas = 2;
        public Moto(
            string chassi,
            string placa,
            string modelo,
            int data,
            double potencia,
            string cor,
            decimal valor,
            EOpcao tipo
        ) : base(chassi, placa, modelo, data, potencia, cor, valor, tipo) { }

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

                WriteLine("\n ---- Moto Vendida! ---- \n");
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {id}, CPF comprador {cpf}, Valor: {valor} \n");
                ResetColor();
            }
        }
    }
}
