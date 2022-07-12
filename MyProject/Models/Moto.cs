namespace Automovel
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
            decimal valor
        ) : base(chassi, placa, modelo, data, potencia, cor, valor) { }
    }
}
