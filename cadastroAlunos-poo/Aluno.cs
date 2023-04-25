using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadastroAlunos_poo
{
    public class Aluno
    {
        //Propriedades
        public string nome = "";
        public string curso = "";
        public string idade = "";
        public string rg = "";
        public bool bolsista = false;
        public float mediaFinal = 0;
        public float mensalidade = 0;

        //Métodos
        public void VerMediaFinal()
        {
            Console.WriteLine($"A média final do aluno é {mediaFinal}"); 
        }

        public void VerMensalidade()
        {
            if (mediaFinal >= 8)
            {
                Console.WriteLine($"A mensalidade do aluno é {mensalidade * 0.5} com a bolsa de 50%");
            }
            else if (mediaFinal > 6)
            {
                Console.WriteLine($"A mensalidade do aluno é {mensalidade * 0.7} com a bolsa de 30%");
            }
            else
            {
                Console.WriteLine($"A mensalidade do aluno é {mensalidade} com valor integral");
            }
        }
    }
}