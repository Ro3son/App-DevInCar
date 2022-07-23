namespace Automovel.Models
{
    public class HistoricoVendas
    {
        public Veiculo DadosDoVeiculo { get; set; }
        public string? CPFDoComprador { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        public HistoricoVendas(Veiculo dados)
        {
            DadosDoVeiculo = dados;
            Data = DateTime.Now;
        }
    }
}
