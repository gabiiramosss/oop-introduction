using System.Globalization;
using currencyConverter_oop;

Console.WriteLine($"---------------------------------------------");
Console.WriteLine($"¦           Conversor de Moedas             ¦");
Console.WriteLine($"---------------------------------------------");

Console.WriteLine($"Digite o valor que deseja converter:");
float valor = float.Parse(Console.ReadLine());

Console.WriteLine(@$"Ótimo! Agora escolha a opção de conversão:
1 - Real para dólar
2 - Dólar para real

0 - Sair");
char resposta = char.Parse(Console.ReadLine());

switch (resposta)
{
    case '1':
        Console.WriteLine($"O valor final será {CurrencyConverter.RealParaDolar(valor).ToString("C2", new CultureInfo("en-us"))}");
        break;

    case '2':
        Console.WriteLine($"O valor final será {CurrencyConverter.DolarParaReal(valor):c}");
        break;

    case '0':
        Console.WriteLine($"Volte sempre!");
        break;
}