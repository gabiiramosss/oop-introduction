using lists_oop;

//CRUD

//CREATE
//Criar uma lista de objetos (produtos)
List<Produto> produtos = new List<Produto>();

//Inserir objetos de produtos na lista
//Primeira forma
produtos.Add(
    new Produto(1234, "camiseta lacoste", 19.99f)
);

//Segunda forma
Produto camisetaArmani = new Produto(1235, "camiseta armani", 49.90f);
produtos.Add(camisetaArmani);

//Lista com vários produtos
produtos.AddRange(new List<Produto>
{
    new Produto(1236, "camiseta polo", 39.99f),
    new Produto(1237, "camiseta adidas", 29.90f),
});

//READ
Console.WriteLine($"Produtos antes da alteração:");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");  
}

//UPDATE
//Acessar um objeto na lista para manipulá-lo
Produto produtoEncontrado = produtos.Find(item => item.Codigo == 1237); //Encontra um item na lista para poder manipulá-lo
int index = produtos.IndexOf(produtoEncontrado); //Encontra o index do item encontrado
Console.WriteLine($"O indíce do produto encontrado é {index}"); //Exibe no console
produtoEncontrado.Preco = 59.90f; //Fazer alterações
produtos.RemoveAt(index); //Remover o item antigo da lista
produtos.Insert(index, produtoEncontrado); //Devolver o item atualizado no lugar

Console.WriteLine($"Produtos depois da alteração:");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");
}

//DELETE
produtos.RemoveAt(index); //Remover o item antigo da lista