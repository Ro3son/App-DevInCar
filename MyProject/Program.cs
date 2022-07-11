using System;

namespace Automovel
{
    public class Program
    {
        static void Main()
        {
            IVeiculo moto = new Moto();
            moto.NumeroChassi = "123MRERTXP20";

            Console.WriteLine(moto.NumeroChassi);
        }
    }
}
