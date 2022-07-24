using static System.Console;

namespace Automovel.Models
{
    public class Carro : Veiculo
    {
        int portas;
        public string? combustivel;
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
            WriteLine("\n --------------------------------------- \n");

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
            WriteLine("\n --------------------------------------- \n");
        }

        public override List<Veiculo> ListarVeiculos()
        {   
            List<Carro> Carros = new List<Carro>();

            Carros.Add(
                new Carro { NumeroChassi = "CHASSIGHJOLNQSED4", Placa = "CAR3XFV", NomeModelo = "Fiat Uno", 
                DataFabricacao = 2019, Potencia = 75.0, Cor = "Vermelho", Valor = 43.807m, Combustivel = "Flex", Status = EStatus.Disponivel });
            Carros.Add(
                new Carro { NumeroChassi = "CHASSIRFV567IJNSW", Placa = "3XFVPCO", NomeModelo = "VW Gol", 
                DataFabricacao = 2018, Potencia = 82.0, Cor = "Preto", Valor = 47.454m, Combustivel = "Gasolina", Status = EStatus.Disponivel });
            Carros.Add(
                new Carro { NumeroChassi = "CHASSIOLXSEM2F4F7", Placa = "FVCAR37", NomeModelo = "Renault Duster", 
                DataFabricacao = 2017, Potencia = 118.0, Cor = "Branco", Valor = 67.920m, Combustivel = "Flex", Status = EStatus.Vendido });
            Carros.Add(
                new Carro { NumeroChassi = "CHASSIZXC567NJIK8", Placa = "BAA1234", NomeModelo = "Chevrolet Onix", 
                DataFabricacao = 2019, Potencia = 78.0, Cor = "Vermelho", Valor = 53.345m, Combustivel = "Gasolina", Status = EStatus.Vendido });
            Carros.Add(
                new Carro { NumeroChassi = "CHASSIXCVFGHBN56K", Placa = "UKC1DER", NomeModelo = "Renault Duster", 
                DataFabricacao = 2021, Potencia = 118.0, Cor = "Branco", Valor = 77.920m, Combustivel = "Flex", Status = EStatus.VendidoMaiorValor });
            Carros.Add(
                new Carro { NumeroChassi = "CHASSIHJKSOLC2FU4", Placa = "ABC1234", NomeModelo = "Chevrolet Onix", 
                DataFabricacao = 2018, Potencia = 78.0, Cor = "Vermelho", Valor = 42.345m, Combustivel = "Gasolina", Status = EStatus.VendidoMenorValor });
            
            var carros = 
                from carro in Carros 
                where carro.Status == EStatus.Disponivel 
                select carro;

            WriteLine("\n ---- Lista de Carros Disponíveis ---- \n");

            foreach (var carro in carros)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {carro.NumeroChassi}, Placa: {carro.Placa}, Modelo: {carro.NomeModelo}, Portas: {portas}\n"
                        + $"Potência: {carro.Potencia} (cv), Ano: {carro.DataFabricacao}, Cor: {carro.Cor}, Preço: {carro.Valor}\n"
                );
                ResetColor();
            }

            var carrosVendidos = 
                from carro in Carros 
                where carro.Status == EStatus.Vendido 
                select carro;

            WriteLine("\n ---- Lista de Carros Vendidos ---- \n");

            foreach (var carro in carrosVendidos)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {carro.NumeroChassi}, Placa: {carro.Placa}, Modelo: {carro.NomeModelo}, Portas: {portas}\n"
                        + $"Potência: {carro.Potencia} (cv), Ano: {carro.DataFabricacao}, Cor: {carro.Cor}, Preço: {carro.Valor}\n"
                );
                ResetColor();
            }

            var carrosVendidosMaiorValor =
                from carro in Carros
                where carro.Status == EStatus.VendidoMaiorValor
                select carro;

            WriteLine("\n ---- Lista de Carros Vendidos (Maior Valor) ---- \n");

            foreach (var carro in carrosVendidosMaiorValor)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {carro.NumeroChassi}, Placa: {carro.Placa}, Modelo: {carro.NomeModelo}, Portas: {portas}\n"
                        + $"Potência: {carro.Potencia} (cv), Ano: {carro.DataFabricacao}, Cor: {carro.Cor}, Preço: {carro.Valor}\n"
                );
                ResetColor();
            }

            var carrosVendidosMenorValor =
                from carro in Carros
                where carro.Status == EStatus.VendidoMenorValor
                select carro;

            WriteLine("\n ---- Lista de Carros Vendidas (Menor Valor) ---- \n");

            foreach (var carro in carrosVendidosMenorValor)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {carro.NumeroChassi}, Placa: {carro.Placa}, Modelo: {carro.NomeModelo}, Portas: {portas}\n"
                        + $"Potência: {carro.Potencia} (cv), Ano: {carro.DataFabricacao}, Cor: {carro.Cor}, Preço: {carro.Valor}\n"
                );
                ResetColor();
            }
            return base.ListarVeiculos();
        }
    }
}
