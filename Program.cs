using System;

namespace AreaTrianguloRet_At_Etec_
{
    class Program
    {
        static void Main(string[] args)
        {
            double PrimeiroNumero;
            double SegundoNumero;
            
            Console.Write("Base: ");
            PrimeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura: ");
            SegundoNumero = Convert.ToDouble(Console.ReadLine());
            
            double resultado = PrimeiroNumero / SegundoNumero;

            Console.WriteLine($"A area e: {resultado:N} ");
        }
    }
}
