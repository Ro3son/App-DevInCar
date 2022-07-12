namespace Automovel
{
    public class Moto : Veiculo
    {
        public int _rodas = 2;
        public Moto(
            string chassi,
            string placa,
            string marca,
            int data,
            double potencia,
            string cor,
            decimal valor
        ) : base(chassi, placa, marca, data, potencia, cor, valor) { }
    }
}
