using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace celular_poo
{
    public class Celular
    {
        //Propriedades
        public string modelo = "";
        public string cor = "";
        public string tamanho = "";
        public bool ligado = false;

        //Métodos
        public void Ligar()
        {
            if (ligado == true)
            {
                Console.WriteLine($"O celular ligou!");
            }
        }
        public void FazerLigacao()
        {
            if (ligado == true)
            {
                Console.WriteLine($"O celular fez ligações.");
            }
        }
        public void EnviarMensagem()
        {
            if (ligado == true)
            {
                Console.WriteLine($"O celular enviou mensagens.");
            }
        }
        public void Desligar()
        {
            if (ligado == true)
            {
                Console.WriteLine($"O celular desligou!");
            }
            ligado = false;
        }
    }
}