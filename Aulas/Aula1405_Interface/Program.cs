using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            Console.WriteLine("Carro criado, velocidade inicial: " + c.Velocidade);
            c.Acelerar();
            c.Acelerar();

            AcelerarBastante(c);
            Console.WriteLine("Carro, velocidade atual: " + c.Velocidade);

            Onibus o = new Onibus();
            Console.WriteLine("Ônibus criado, velocidade inicial: " + o.Velocidade);
            o.Acelerar();
            AcelerarBastante(o);
            Console.WriteLine("Ônibus, velocidade atual: " + o.Velocidade);
            Console.ReadKey();    
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for (int i = 0; i < 10; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
