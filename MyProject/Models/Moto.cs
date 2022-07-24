using static System.Console;

namespace Automovel.Models
{
    public class Moto : Veiculo
    {
        private int rodas;

        public Moto()
        {
            rodas = 2;
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

                WriteLine("\n ---- Moto Vendida! ---- \n");
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {Placa}, CPF comprador: {CPF}, Valor: {Valor} \n");
                ResetColor();
            }
            WriteLine("\n --------------------------------------- \n");
        }

        public override List<Veiculo> ListarVeiculos()
        {
            List<Moto> Motos = new List<Moto>();

            Motos.Add(
                new Moto { NumeroChassi = "CHASSI12454T4T456", Placa = "PLC1234", NomeModelo = "CG 160 Titan", 
                DataFabricacao = 2022, Potencia = 15.1, Cor = "Cinza", Valor = 14.620m, Status = EStatus.Disponivel });
            Motos.Add(
                new Moto { NumeroChassi = "CHASSI123DFGEVGBU", Placa = "BRA2S5D", NomeModelo = "CG 160 Fan",
                DataFabricacao = 2017, Potencia = 15.1, Cor = "Azul", Valor = 13.480m, Status = EStatus.Disponivel });
            Motos.Add(
                new Moto { NumeroChassi = "CHASSIQER234GYHJC", Placa = "CBA3S5K", NomeModelo = "CG 160 Cargo", 
                DataFabricacao = 2021, Potencia = 15.1, Cor = "Branco", Valor = 13.650m, Status = EStatus.Disponivel });
            Motos.Add(
                new Moto { NumeroChassi = "CHASSIYUIH78VR67J", Placa = "SPA1SL3", NomeModelo = "CG 160 Start", 
                DataFabricacao = 2019, Potencia = 15.1, Cor = "Prata", Valor = 12.280m, Status = EStatus.Vendido });
            Motos.Add(
                new Moto { NumeroChassi = "CHASSIASDXDE2WE4Z", Placa = "FGH3RT3", NomeModelo = "CG 160 Cargo", 
                DataFabricacao = 2017, Potencia = 15.1, Cor = "Preto", Valor = 11.650m, Status = EStatus.Vendido });
            Motos.Add(
                new Moto { NumeroChassi = "CHASSIPLM910SXEC4", Placa = "M070127", NomeModelo = "CG 160 Start", 
                DataFabricacao = 2020, Potencia = 15.1, Cor = "Cinza", Valor = 15.280m, Status = EStatus.VendidoMaiorValor });
            Motos.Add(
                new Moto { NumeroChassi = "CHASSIRFDETFODOCX", Placa = "BGT3AS6", NomeModelo = "CG 160 Start", 
                DataFabricacao = 2020, Potencia = 15.1, Cor = "Amarelo", Valor = 16.880m, Status = EStatus.VendidoMaiorValor });
            Motos.Add(
                new Moto { NumeroChassi = "CHASSIQAXOL469UDJ", Placa = "M070127", NomeModelo = "CG 160 Start", 
                DataFabricacao = 2015, Potencia = 15.1, Cor = "Cinza", Valor = 10.280m, Status = EStatus.VendidoMenorValor });
            Motos.Add(
                new Moto { NumeroChassi = "CHASSICVMBKSP4IFI", Placa = "KLMSPO3", NomeModelo = "CG 160 Start", 
                DataFabricacao = 2014, Potencia = 15.1, Cor = "Azul", Valor = 8.280m, Status = EStatus.VendidoMenorValor });
                
            var motos = 
                from moto in Motos 
                where moto.Status == EStatus.Disponivel 
                select moto;

            WriteLine("\n ---- Lista de Motos Disponíveis ---- \n");

            foreach (var moto in motos)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo}, Rodas: {rodas}\n"
                        + $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                );
                ResetColor();
            }

            var motosVendidas = 
                from moto in Motos 
                where moto.Status == EStatus.Vendido 
                select moto;

            WriteLine("\n ---- Lista de Motos Vendidas ---- \n");

            foreach (var moto in motosVendidas)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo}, Rodas: {rodas}\n"
                        + $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                );
                ResetColor();
            }

            var motosVendidasMaiorValor =
                from moto in Motos
                where moto.Status == EStatus.VendidoMaiorValor
                select moto;

            WriteLine("\n ---- Lista de Motos Vendidas (Maior Valor) ---- \n");

            foreach (var moto in motosVendidasMaiorValor)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo}, Rodas: {rodas}\n"
                        + $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                );
                ResetColor();
            }

            var motosVendidasMenorValor =
                from moto in Motos
                where moto.Status == EStatus.VendidoMenorValor
                select moto;

            WriteLine("\n ---- Lista de Motos Vendidas (Menor Valor) ---- \n");

            foreach (var moto in motosVendidasMenorValor)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {moto.NumeroChassi}, Placa: {moto.Placa}, Modelo: {moto.NomeModelo}, Rodas: {rodas}\n"
                        + $"Potência: {moto.Potencia} (cv), Ano: {moto.DataFabricacao}, Cor: {moto.Cor}, Preço: {moto.Valor}\n"
                );
                ResetColor();
            }

            return base.ListarVeiculos();
        }
    }
}
