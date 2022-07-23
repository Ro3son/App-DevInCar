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
        public EMenu Tipo { get; set; }

        public Veiculo(
            string chassi,
            string placa,
            string modelo,
            int data,
            double potencia,
            string cor,
            decimal valor,
            EMenu tipo
        )
        {
            NumeroChassi = Convert.ToString(new Random().Next(17));
            Placa = Convert.ToString(new Random().Next(7));
            NomeModelo = modelo;
            DataFabricacao = data;
            Potencia = potencia;
            Cor = cor;
            Valor = valor;
            CPF = 0;
            Tipo = tipo;
        }

        public abstract void VenderVeiculos();

        public List<Veiculo> ListarInformacoes() 
        { 
            return new List<Veiculo>();
        }

        public void EditarInformacoes() { }
    }
}
