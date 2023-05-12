using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_oop
{
    public interface ICarrinho
    {
        void Adicionar(Produto produto);
        void Listar();
        void Atualizar(int codigo, Produto novoProduto);
        void Remover(Produto produto);
        void ValorTotal();
    }
}