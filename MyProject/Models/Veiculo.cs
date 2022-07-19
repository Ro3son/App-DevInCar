using static System.Console;

namespace Automovel.Models
{
    public abstract class Veiculo
    {
        public string NumeroChassi { get; set; }
        public string Placa { get; set; }
        public string NomeModelo { get; set; }
        public int DataFabricacao { get; set; }
        public double Potencia { get; set; }
        public string Cor { get; set; }
        public decimal Valor { get; set; }
        public int CPF { get; set; }
        public ETipo Tipo { get; set; }

        public Veiculo(
            string chassi,
            string placa,
            string modelo,
            int data,
            double potencia,
            string cor,
            decimal valor,
            ETipo tipo
        )
        {
            NumeroChassi = chassi;
            Placa = placa;
            NomeModelo = modelo;
            DataFabricacao = data;
            Potencia = potencia;
            Cor = cor;
            Valor = valor;
            Tipo = tipo;
        }

        public void VenderVeiculos()
        {
            WriteLine("Deseja vender o veículo disponível? (s/n)");
            var input = ReadLine();
            if (input == "s")
            {
                WriteLine("Digite o ID(placa) do veículo: ");
                var id = ReadLine();
                WriteLine("Digite o CPF(somente números) do comprador: ");
                var cpf = ReadLine();
                WriteLine("Digite o valor do veículo: ");
                var valor = ReadLine();
                WriteLine("\n ---- Moto Vendida! ---- \n");
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {id}, CPF comprador {cpf}, Valor: {valor} \n");
                ResetColor();
            }
        }
    }
}
