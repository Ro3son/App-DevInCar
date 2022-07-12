namespace Automovel
{
    public class Veiculo
    {
        public string NumeroChassi { get; set; }
        public string Placa { get; set; }
        public string NomeMarca { get; set; }
        public int DataFabricacao { get; set; }
        public double Potencia { get; set; }
        public string Cor { get; set; }
        public decimal Valor { get; set; }
        public int CPF { get; set; }

        public Veiculo(
            string chassi,
            string placa,
            string marca,
            int data,
            double potencia,
            string cor,
            decimal valor
        )
        {
            NumeroChassi = chassi;
            Placa = placa;
            NomeMarca = marca;
            DataFabricacao = data;
            Potencia = potencia;
            Cor = cor;
            Valor = valor;
        }
        public void VenderVeiculos() 
        { 

        }
    }
}
