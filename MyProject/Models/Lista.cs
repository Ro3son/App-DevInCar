using static System.Console;

namespace Automovel.Models
{
    public class Lista
    {
        public virtual List<Veiculo> ListarTodos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            veiculos.Add(
                new Moto { NumeroChassi = "CHASSI12454T4T456", Placa = "PLC1234", NomeModelo = "CG 160 Titan", 
                DataFabricacao = 2022, Potencia = 15.1, Cor = "Cinza", Valor = 14.620m, Status = EStatus.Disponivel });
            veiculos.Add(
                new Moto { NumeroChassi = "CHASSI123DFGEVGBU", Placa = "BRA2S5D", NomeModelo = "CG 160 Fan",
                DataFabricacao = 2017, Potencia = 15.1, Cor = "Azul", Valor = 13.480m, Status = EStatus.Disponivel });
            veiculos.Add(
                new Moto { NumeroChassi = "CHASSIQER234GYHJC", Placa = "CBA3S5K", NomeModelo = "CG 160 Cargo", 
                DataFabricacao = 2021, Potencia = 15.1, Cor = "Branco", Valor = 13.650m, Status = EStatus.Disponivel });
            
            veiculos.Add(
                new Triciclo { NumeroChassi = "CHASSI123AZXSDCFE4", Placa = "TRI1237", NomeModelo = "Tricity 300", 
                DataFabricacao  = 2022, Potencia = 20.6, Cor = "Azul", Valor = 48.605m, Status = EStatus.Disponivel });
            veiculos.Add(
                new Triciclo { NumeroChassi = "CHASSI678GTUHJKXOL", Placa = "CITY123", NomeModelo = "Tricity 125", 
                DataFabricacao = 2022, Potencia = 9.0, Cor = "Branco", Valor = 24.009m, Status = EStatus.Disponivel });
            
            veiculos.Add(
                new Camionete { NumeroChassi = "CHASSIFA3DVFOLM1D7", Placa = "PLCAR34", NomeModelo = "Fiat Toro",
                DataFabricacao = 2021, Potencia = 139.0, Valor = 103.394m, Combustivel = "Diesel", CapacidadeDeCarga = 820, Status = EStatus.Disponivel });
            veiculos.Add(
                new Camionete { NumeroChassi = "CHASSIYUI789O50HL", Placa = "TYT678X", NomeModelo = "Toyota Hilux",
                DataFabricacao = 2021, Potencia = 204.0, Valor = 238.090m, Combustivel = "Diesel", CapacidadeDeCarga = 910, Status = EStatus.Disponivel });
            veiculos.Add(
                new Camionete { NumeroChassi = "CHASSL3ADFTTH7OGH", Placa = "CHVR3FL", NomeModelo = "Chevrolet s10",
                DataFabricacao = 2022, Potencia = 206.0, Valor = 113.692m, Combustivel = "Gasolina", CapacidadeDeCarga = 850, Status = EStatus.Disponivel });
            
            WriteLine("\n ---- Todos os veículos ---- \n");

            foreach (var veiculo in veiculos)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine(
                    $"Modelo {veiculo.NomeModelo}, Potência: {veiculo.Potencia}(cv)\n" +
                    $"Ano: {veiculo.DataFabricacao}, Cor: {veiculo.Cor}, Preço: {veiculo.Valor}\n"
                );
                ResetColor();
            }
            return veiculos;
        }
    }
}
