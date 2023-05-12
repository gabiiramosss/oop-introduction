using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_oop
{
    public class Produto
    {
        public int Codigo;
        public string Nome;
        public float Preco;
        
        public Produto()
        {
            
        }
        public Produto(int codigo, string nome, float preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}