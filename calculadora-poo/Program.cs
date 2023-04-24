using calculadora_poo;

Calculadora operacao= new Calculadora();

Console.WriteLine($"Insira a operação a ser realizada: + , - , * , /");
char op = char.Parse(Console.ReadLine());

switch (op)
{
    case '+':
        Console.WriteLine($"Resultado: {operacao.Somar()}");
        break;

    case '-':
        Console.WriteLine($"Resultado: {operacao.Subtrair()}");
        break;

    case '*':
        Console.WriteLine($"Resultado: {operacao.Multiplicar()}");
        break;

    case '/':
        Console.WriteLine($"Resultado: {operacao.Dividir()}");
        break;
}
