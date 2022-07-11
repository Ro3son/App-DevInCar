using System;

namespace Automovel
{
    public class Program
    {
        static void Main()
        {
            Moto moto = new Moto();
            moto.NumeroChassi = "123ERTGCH234";
            moto.Potencia = 15.1;
            moto.Rodas = 2;

            Console.WriteLine(
                @$"Chassi: {moto.NumeroChassi}, 
            Potência: {moto.Potencia} (cv),
            Rodas: {moto.Rodas}"
            );
        }
    }
}
