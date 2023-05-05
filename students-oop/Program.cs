//Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.
//Crie uma classe Aluno com as seguintes propriedades:

//Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 

//Também teremos os métodos: VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

//obs:
//bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
//bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
//outros casos a mensalidade será integral
//Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.

//Acrescente o que achar necessário.
using cadastroAlunos_poo;

Aluno a1 = new Aluno();

Console.WriteLine($"---------------------------------------------");
Console.WriteLine($"¦             Cadastro de Aluno             ¦");
Console.WriteLine($"---------------------------------------------");

Console.WriteLine($"Digite o nome do aluno: ");
a1.nome = Console.ReadLine();

Console.WriteLine($"Digite o curso do aluno: ");
a1.curso = Console.ReadLine();

Console.WriteLine($"Digite a idade do aluno: ");
a1.idade = Console.ReadLine();

Console.WriteLine($"Digite o RG do aluno: ");
a1.rg = Console.ReadLine();

Console.WriteLine($"O aluno é bolsista? Digite 's' ou 'n'.");
string bolsistaOp = Console.ReadLine().ToLower();
if (bolsistaOp == "s")
{
    a1.bolsista = true;
}
else
{
    a1.bolsista = false;
}
//Com operador ternário: a1.bolsista = bolsistaOp == 's' ? true : false;

Console.WriteLine($"Digite a média final do aluno: ");
a1.mediaFinal = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a mensalidade do aluno: ");
a1.mensalidade = float.Parse(Console.ReadLine());

static char menu()
{
    Console.WriteLine(@$"
    O que deseja fazer?
    1 - Ver média final
    2 - Ver mensalidade

    0 - Sair
    ");
    return char.Parse(Console.ReadLine());
}

do
{
    switch (menu())
    {
        case '1':
            Console.WriteLine($"");
            a1.VerMediaFinal();
            break;
        case '2':
            Console.WriteLine($"");
            a1.VerMensalidade();
            break;
    }
} while (menu() != '0');
