using interface_oop;

//Instancia do nosso objeto da classe carrinho
Carrinho carrinho = new Carrinho();

Produto p1 = new Produto(1, "Call of Duty", 480f);
Produto p2 = new Produto(2, "Mineirinho Ultra Adventures", 2.30f);
Produto p3 = new Produto(3, "The Last of Us", 150f);

//Adicionar
carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

//Listar
carrinho.Listar();
Console.ForegroundColor = ConsoleColor.DarkCyan;
carrinho.ValorTotal();
Console.ResetColor();
Console.WriteLine();

//Remover
carrinho.Remover(p1);

//Listar depois de remover
carrinho.Listar();
Console.ForegroundColor = ConsoleColor.DarkCyan;
carrinho.ValorTotal();
Console.ResetColor();
Console.WriteLine();

//Atualizar
    //Criar um novo objeto com os dados atualizados
Produto produtoAtualizado = new Produto();
produtoAtualizado.Nome = "Mineirinho Director's Cut";
produtoAtualizado.Preco = 2.50f;

carrinho.Atualizar(2, produtoAtualizado);

carrinho.Listar();
Console.ForegroundColor = ConsoleColor.DarkCyan;
carrinho.ValorTotal();
Console.ResetColor();
Console.WriteLine();