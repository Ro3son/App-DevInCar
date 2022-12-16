using System.Runtime.CompilerServices;
using static System.Console;

namespace Automovel.Models
{
    public class Venda
    {
        public Veiculo Veiculo { get; set; }
        public DateTime Data { get; set; }

        public Venda(Veiculo _veiculo)
        {
            Veiculo = _veiculo;
            Data = DateTime.Now;
        }

        public void HistoricoVenda()
        {
            WriteLine($" Chassi: {Veiculo.NumeroChassi}\n CPFDoComprador: {Veiculo.CPF}\n Valor: {Veiculo.Valor}\n Data: {Data}");
        }
    }
}
