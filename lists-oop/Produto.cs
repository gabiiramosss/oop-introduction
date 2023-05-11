using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lists_oop
{
    public class Produto
    {
        //propriedades
        public int Codigo;
        public string Nome;
        public float Preco;

        //construtor vazio
        public Produto()
        {
            
        }

        //construtor com os atributos
        public Produto(int codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}