// using Nova_pasta;

// //Instanciando o objeto da classe Personagem
// Personagem tony = new Personagem();

// //exibindo informações do objeto
// Console.WriteLine(tony.nome);
// Console.WriteLine(tony.idade);
// Console.WriteLine(tony.armadura);
// Console.WriteLine(tony.ia);

// //chamando os métodos da classe

// //só invocar pq ele só exibe (void)
// tony.Atacar();

// //usar cwl pois o método retorna string
// Console.WriteLine(tony.Defender());

// //só invocar pq ele só exibe (void)
// tony.RestaurarArmadura();

using Nova_pasta;

//Instanciando o objeto da classe Personagem
Personagem p1 = new Personagem();

Console.WriteLine($"Digite o nome do seu personagem: ");
p1.nome = Console.ReadLine();

Console.WriteLine($"Digite a idade do seu personagem: ");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o nome da armadura do seu personagem: ");
p1.armadura = Console.ReadLine();

Console.WriteLine($"Informe a I.A que o seu personagem utiliza: ");
p1.ia = Console.ReadLine();

Console.WriteLine(@$"
Nome do personagem: {p1.nome}
Idade do personagem: {p1.idade}
Armadura: {p1.armadura}
I.A: {p1.ia}
");