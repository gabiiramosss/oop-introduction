using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_pasta
{
    public class Personagem
    {
        //Propriedades
        //assinatura + tipo + nome = valor
        public string nome = "Tony Stark";
        public int idade = 35;
        public string armadura = "Bleeding Edge";
        public string ia = "Jarvis";

        //Métodos
        public void Atacar()
        {
            Console.WriteLine($"O personagem atacou!");
        }
        public string Defender()
        {
            return "O personagem defendeu!";
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"O personagem restaurou a armadura!");
        }
    }
}