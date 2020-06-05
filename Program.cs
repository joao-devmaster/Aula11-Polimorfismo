using System;

namespace Aula11POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo bmw1200 = new Calculo();
            System.Console.WriteLine( bmw1200.calcularVelocidade());

            System.Console.WriteLine(bmw1200.calcularVelocidade(220));

            System.Console.WriteLine(bmw1200.calcularVelocidade(270,50));

            



            
        }
    }
}
