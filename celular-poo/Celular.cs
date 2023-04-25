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
            Console.WriteLine($"O celular ligou!");
        }
        public void FazerLigacao()
        {
            Console.WriteLine($"O celular fez ligações.");
        }
        public void EnviarMensagem()
        {
            Console.WriteLine($"O celular enviou mensagens.");
        }  
        public void Desligar()
        {
            Console.WriteLine($"O celular desligou!");
            ligado = false;
        }
    }
}