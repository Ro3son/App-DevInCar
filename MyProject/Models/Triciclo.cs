using static System.Console;

namespace Automovel.Models
{
    public class Triciclo : Veiculo
    {
        private int rodas;

        public Triciclo()
        {
            rodas = 3;
            CPF = CPF;
            Valor = Valor;
            Placa = Placa;
        }

        public override void VenderVeiculos()
        {   
            WriteLine("\n --------------------------------------- \n");

            WriteLine("Deseja vender algum veículo disponível? (s/n)");

            var input = ReadLine();
            WriteLine("\n");

            if (input == "s")
            {
                WriteLine("Digite o ID(placa) do veículo: ");
                Placa = ReadLine();

                WriteLine("Digite o CPF(somente números) do comprador: ");
                CPF = ReadLine();

                WriteLine("Digite o valor do veículo: ");
                Valor = Convert.ToDecimal(ReadLine());

                WriteLine("\n ---- Triciclo Vendido! ---- \n");
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {Placa}, CPF comprador {CPF}, Valor: {Valor} \n");
                ResetColor();
            }
            WriteLine("\n --------------------------------------- \n");
        }
        public override List<Veiculo> ListarVeiculos()
        {   
            List<Triciclo> Triciclos = new List<Triciclo>();

            Triciclos.Add(
                new Triciclo { NumeroChassi = "CHASSI123AZXSDCFE4", Placa = "TRI1237", NomeModelo = "Tricity 300", 
                DataFabricacao  = 2022, Potencia = 20.6, Cor = "Azul", Valor = 48.605m, Status = EStatus.Disponivel });
            Triciclos.Add(
                new Triciclo { NumeroChassi = "CHASSI678GTUHJKXOL", Placa = "CITY123", NomeModelo = "Tricity 125", 
                DataFabricacao = 2022, Potencia = 9.0, Cor = "Branco", Valor = 24.009m, Status = EStatus.Disponivel });
            Triciclos.Add(
                new Triciclo { NumeroChassi = "CHASSIABCAZRL50GYE", Placa = "CRLF46Y", NomeModelo = "Tricity 125", 
                DataFabricacao = 2021, Potencia = 9.0, Cor = "Azul", Valor = 25.100m, Status = EStatus.Vendido });
            Triciclos.Add(   
                new Triciclo { NumeroChassi = "CHASSIRTYMKO5B8M0Z", Placa = "BA12K45", NomeModelo = "Tricity 300", 
                DataFabricacao  = 2022, Potencia = 20.6, Cor = "Preto", Valor = 58.805m, Status = EStatus.VendidoMaiorValor });
            Triciclos.Add(
                new Triciclo { NumeroChassi = "CHASSI678GTUHJKXOL", Placa = "CCOL3SK", NomeModelo = "Tricity 125", 
                DataFabricacao = 2022, Potencia = 9.0, Cor = "Cinza", Valor = 34.109m, Status = EStatus.VendidoMenorValor });
            
            var triciclos = 
                from triciclo in Triciclos
                where triciclo.Status == EStatus.Disponivel 
                select triciclo;

            WriteLine("\n ---- Lista de triciclos Disponíveis ---- \n");

            foreach (var triciclo in triciclos)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {triciclo.NumeroChassi}, Placa: {triciclo.Placa}, Modelo: {triciclo.NomeModelo} Rodas: {rodas}\n"
                        + $"Potência: {triciclo.Potencia} (kw), Ano: {triciclo.DataFabricacao}, Cor: {triciclo.Cor}, Preço: {triciclo.Valor}\n"
                );
                ResetColor();
            }

            var triciclosVendidos = 
                from triciclo in Triciclos
                where triciclo.Status == EStatus.Vendido 
                select triciclo;

            WriteLine("\n ---- Lista de triciclos Vendidos ---- \n");

            foreach (var triciclo in triciclosVendidos)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {triciclo.NumeroChassi}, Placa: {triciclo.Placa}, Modelo: {triciclo.NomeModelo} Rodas: {rodas}\n"
                        + $"Potência: {triciclo.Potencia} (kw), Ano: {triciclo.DataFabricacao}, Cor: {triciclo.Cor}, Preço: {triciclo.Valor}\n"
                );
                ResetColor();
            }

            var triciclosVendidosMaiorValor =
                from triciclo in Triciclos
                where triciclo.Status == EStatus.VendidoMaiorValor
                select triciclo;

            WriteLine("\n ---- Lista de triciclos Vendidos (Maior Valor) ---- \n");

            foreach (var triciclo in triciclosVendidosMaiorValor)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {triciclo.NumeroChassi}, Placa: {triciclo.Placa}, Modelo: {triciclo.NomeModelo} Rodas: {rodas}\n"
                        + $"Potência: {triciclo.Potencia} (kw), Ano: {triciclo.DataFabricacao}, Cor: {triciclo.Cor}, Preço: {triciclo.Valor}\n"
                );
                ResetColor();
            }

            var triciclosVendidosMenorValor =
                from triciclo in Triciclos
                where triciclo.Status == EStatus.VendidoMenorValor
                select triciclo;

            WriteLine("\n ---- Lista de triciclos Vendidos (Menor Valor) ---- \n");

            foreach (var triciclo in triciclosVendidosMenorValor)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {triciclo.NumeroChassi}, Placa: {triciclo.Placa}, Modelo: {triciclo.NomeModelo} Rodas: {rodas}\n"
                        + $"Potência: {triciclo.Potencia} (kw), Ano: {triciclo.DataFabricacao}, Cor: {triciclo.Cor}, Preço: {triciclo.Valor}\n"
                );
                ResetColor();
            }

            return base.ListarVeiculos();
        }

    }
}
