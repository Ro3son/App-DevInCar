using System;

namespace Automovel
{
    public class Program
    {
        static void Main()
        {
            Moto moto = new Moto(
                "CHASSI12454T4T456",
                "PLC123",
                "Honda",
                2021,
                15.1,
                "Preto",
                12.000m
            );
            Console.WriteLine(
            @$"Chassi: {moto.NumeroChassi}, 
            Potência: {moto.Potencia} (cv),
            Rodas: {moto._rodas}"
            );
        }
    }
}
