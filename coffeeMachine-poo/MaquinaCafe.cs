using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coffeeMachine_poo
{
    public class MaquinaCafe
    {
        //propriedades
        public int acucarDisponivel;

        //métodos
        public MaquinaCafe(int acucarDisponivel)
        {
            this.acucarDisponivel = acucarDisponivel;
        }

        public void fazerCafe()
        {
            Console.WriteLine($"Deseja informar a quantidade de açúcar a ser colocada no seu cafézinho (em gramas)?");
            Console.WriteLine($"Digite 's' ou 'n'.");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's')
            {
                Console.WriteLine($"Eba! Quanto seria?");
                int acucar = int.Parse(Console.ReadLine());

                if (acucar > acucarDisponivel)
                {
                    Console.WriteLine($"Ahh, não temos essa quantidade disponível, mas colocaremos {acucarDisponivel}g, tudo bem?");
                    Console.WriteLine($"Digite 's' ou 'n'.");
                    char resposta2 = char.Parse(Console.ReadLine());

                    if (resposta2 == 's')
                    {
                        Console.WriteLine($"Ótimo, estamos preparando seu cafézinho!");
                    }
                    else
                    {
                        Console.WriteLine($"Que pena! Recomendamos que recomece o sistema e refaça seu pedido.");
                    }
                }
                else
                {
                    Console.WriteLine($"Ótimo, estamos preparando seu cafézinho!");
                }

            }
            else
            {
                Console.WriteLine($"Por padrão, adicionamos 10g de açúcar quando o usuário não nos informa com precisão. Deseja seu cafézinho sem açúcar?");
                Console.WriteLine($"Digite 's' ou 'n'.");
                char resposta3 = char.Parse(Console.ReadLine());
                
                if (resposta3 == 'n')
                {
                    Console.WriteLine($"Ótimo, estamos preparando seu cafézinho!");
                }
                else
                {
                    Console.WriteLine($"Tudo bem, prepararemos seu cafézinho sem açúcar!");
                }
            }
        }
    }
}