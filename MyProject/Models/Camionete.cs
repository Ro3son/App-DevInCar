using static System.Console;

namespace Automovel.Models
{
    public class Camionete : Veiculo
    {
        int portas;
        public string? combustivel;
        public string? Combustivel { get; set; }
        public int capacidadeDeCarga;
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
            Cor = "Roxa";
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

                WriteLine("Digite o CPF(somente números) do comprador: ");
                CPF = ReadLine();

                WriteLine("Digite o valor do veículo: ");
                Valor = Convert.ToDecimal(ReadLine());

                WriteLine("\n ---- Camionete Vendida! ---- \n");
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Placa: {Placa}, CPF comprador: {CPF}, Valor: {Valor} \n");
                ResetColor();

            }
            WriteLine("\n --------------------------------------- \n");
        }

        public override List<Veiculo> ListarVeiculos()
        {  
            List<Camionete> Camionetes = new List<Camionete>();

            Camionetes.Add( 
                new Camionete { NumeroChassi = "CHASSIFA3DVFOLM1D7", Placa = "PLCAR34", NomeModelo = "Fiat Toro", 
                DataFabricacao = 2021, Potencia = 139.0, Valor = 103.394m, Combustivel = "Diesel", CapacidadeDeCarga = 820, Status = EStatus.Disponivel });
            Camionetes.Add( 
                new Camionete { NumeroChassi = "CHASSIYUI789O50HL", Placa = "TYT678X", NomeModelo = "Toyota Hilux", 
                DataFabricacao = 2021, Potencia = 204.0, Valor = 238.090m, Combustivel = "Diesel", CapacidadeDeCarga = 910, Status = EStatus.Disponivel });
            Camionetes.Add( 
                new Camionete { NumeroChassi = "CHASSL3ADFTTH7OGH", Placa = "CHVR3FL", NomeModelo = "Chevrolet s10", 
                DataFabricacao = 2022, Potencia = 206.0, Valor = 113.692m, Combustivel = "Gasolina", CapacidadeDeCarga = 850, Status = EStatus.Disponivel });
            Camionetes.Add( 
                new Camionete { NumeroChassi = "CHASSIYUI789O50HL", Placa = "TYT678X", NomeModelo = "Toyota Hilux", 
                DataFabricacao = 2020, Potencia = 204.0, Valor = 138.090m, Combustivel = "Diesel", CapacidadeDeCarga = 910, Status = EStatus.Vendido });
            Camionetes.Add( 
                new Camionete { NumeroChassi = "CHASSL3ADFTTH7OGH", Placa = "CHVR3FL", NomeModelo = "Chevrolet s10", 
                DataFabricacao = 2019, Potencia = 206.0, Valor = 113.692m, Combustivel = "Gasolina", CapacidadeDeCarga = 850, Status = EStatus.Vendido });
            Camionetes.Add( 
                new Camionete { NumeroChassi = "CHASSIYUI789O50HL", Placa = "TYT678X", NomeModelo = "Toyota Hilux", 
                DataFabricacao = 2022, Potencia = 204.0, Valor = 248.190m, Combustivel = "Diesel", CapacidadeDeCarga = 910, Status = EStatus.VendidoMaiorValor });
            Camionetes.Add( 
                new Camionete { NumeroChassi = "CHASSL3ADFTTH7OGH", Placa = "CHVR3FL", NomeModelo = "Chevrolet s10", 
                DataFabricacao = 2018, Potencia = 206.0, Valor = 110.602m, Combustivel = "Gasolina", CapacidadeDeCarga = 850, Status = EStatus.VendidoMenorValor });
            
            var camionetes = 
                from camionete in Camionetes
                where camionete.Status == EStatus.Disponivel 
                select camionete;

            WriteLine("\n ---- Lista de Camionetes Disponíveis ---- \n");

            foreach (var camionete in camionetes)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {camionete.NumeroChassi}, Placa: {camionete.Placa}, Modelo: {camionete.NomeModelo}, Portas: {portas}\n"
                        + $"Potência: {camionete.Potencia} (kw), Ano: {camionete.DataFabricacao}, Cor: {camionete.Cor}, Preço: {camionete.Valor}\n"
                );
                ResetColor();
            }

            var camionetesVendidas = 
                from camionete in Camionetes
                where camionete.Status == EStatus.Vendido 
                select camionete;

            WriteLine("\n ---- Lista de Camionetes Vendidas ---- \n");

            foreach (var camionete in camionetesVendidas)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {camionete.NumeroChassi}, Placa: {camionete.Placa}, Modelo: {camionete.NomeModelo}, Portas: {portas}\n"
                        + $"Potência: {camionete.Potencia} (kw), Ano: {camionete.DataFabricacao}, Cor: {camionete.Cor}, Preço: {camionete.Valor}\n"
                );
                ResetColor();
            }

            var camionetesVendidasMaiorValor =
                from camionete in Camionetes
                where camionete.Status == EStatus.VendidoMaiorValor
                select camionete;

            WriteLine("\n ---- Lista de Camionetes Vendidas (Maior Valor) ---- \n");

            foreach (var camionete in camionetesVendidasMaiorValor)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {camionete.NumeroChassi}, Placa: {camionete.Placa}, Modelo: {camionete.NomeModelo}, Portas: {portas}\n"
                        + $"Potência: {camionete.Potencia} (kw), Ano: {camionete.DataFabricacao}, Cor: {camionete.Cor}, Preço: {camionete.Valor}\n"
                );
                ResetColor();
            }

            var camionetesVendidasMenorValor =
                from camionete in Camionetes
                where camionete.Status == EStatus.VendidoMenorValor
                select camionete;

            WriteLine("\n ---- Lista de Camionetes Vendidas (Menor Valor) ---- \n");

            foreach (var camionete in camionetesVendidasMenorValor)
            {
                ForegroundColor = ConsoleColor.DarkGreen;
                WriteLine(
                    $"Chassi: {camionete.NumeroChassi}, Placa: {camionete.Placa}, Modelo: {camionete.NomeModelo}, Portas: {portas}\n"
                        + $"Potência: {camionete.Potencia} (kw), Ano: {camionete.DataFabricacao}, Cor: {camionete.Cor}, Preço: {camionete.Valor}\n"
                );
                ResetColor();
            }

            return base.ListarVeiculos();
        }
    }
}
