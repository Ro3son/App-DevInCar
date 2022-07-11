namespace Automovel
{
    public class Moto : IVeiculo
    {
        private string _chassi;
        public string NumeroChassi
        {
            get => _chassi;
            set => _chassi = value;
        }
        public Moto()
        {
            _chassi = NumeroChassi;
        }
    }
}
