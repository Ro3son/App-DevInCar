using static System.Console;

namespace Automovel.Models
{
    public class Moto : Veiculo
    {
        public int rodas = 2;
        public Moto(
            string chassi,
            string placa,
            string modelo,
            int data,
            double potencia,
            string cor,
            decimal valor,
            ETipo tipo
        ) : base(chassi, placa, modelo, data, potencia, cor, valor, tipo) { }
        
    }
}
