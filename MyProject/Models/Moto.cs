namespace Automovel
{
    public class Moto : Veiculo
    {
        private string _chassi;
        private double _potencia;
        private int _rodas;

        public string NumeroChassi
        {
            get => _chassi;
            set => _chassi = value;
        }
        public double Potencia
        {
            get => _potencia;
            set => _potencia = value;
        }
        public int Rodas
        {
            get => _rodas;
            set => _rodas = value;
        }
        public Moto()
        {
            _chassi = NumeroChassi;
            _potencia = Potencia;
            _rodas = Rodas;
        }
    }
}
