using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora_poo
{
    public class Calculadora
    {
        //Propriedades
        public float numero1 = 0;
        public float numero2 = 0;

        //Métodos
        public float Somar()
        {
            Console.WriteLine($"Insira um número:");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Insira outro número:");
            numero2 = float.Parse(Console.ReadLine());

            return numero1 + numero2;
        }
        public float Multiplicar()
        {
            Console.WriteLine($"Insira um número:");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Insira outro número:");
            numero2 = float.Parse(Console.ReadLine());

            return numero1 * numero2;
        }
        public float Subtrair()
        {
            Console.WriteLine($"Insira um número:");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Insira outro número:");
            numero2 = float.Parse(Console.ReadLine());

            return numero1 - numero2;
        }
        public float Dividir()
        {
            Console.WriteLine($"Insira um número:");
            numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Insira outro número:");
            numero2 = float.Parse(Console.ReadLine());
            
            return numero1 / numero2;
        }
    }
}