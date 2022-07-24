namespace Automovel.Models
{
    public abstract class Veiculo
    {
        public string NumeroChassi { get; set; }
        public string? Placa { get; set; }
        public string? NomeModelo { get; set; }
        public int DataFabricacao { get; set; }
        public double Potencia { get; set; }
        public string? Cor { get; set; }
        public decimal Valor { get; set; }
        public string? CPF { get; set; }
        public EMenu Tipo { get; set; }
        public EStatus Status { get; set; }

        public Veiculo()
        {
            NumeroChassi = Convert.ToString(new Random().Next(17));
            Placa = Convert.ToString(new Random().Next(7));
            NomeModelo = NomeModelo;
            DataFabricacao = DataFabricacao;
            Potencia = Potencia;
            Cor = Cor;
            Valor = Valor;
            CPF = CPF;
            Tipo = Tipo;
            Status = Status;

        }

        public abstract void VenderVeiculos();
        
        public List<Veiculo> veiculos = new List<Veiculo>();
        public virtual List<Veiculo> ListarVeiculos() 
        { 
            return veiculos;
        }
        public void EditarInformacoes() { }
    }
}
