// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.

using celular_poo;

Celular novoCel = new Celular();

Console.WriteLine($"Qual o modelo do celular?");
novoCel.modelo = Console.ReadLine();

Console.WriteLine($"Qual a cor do celular?");
novoCel.cor = Console.ReadLine();

Console.WriteLine($"Qual o tamanho do celular?");
novoCel.tamanho = Console.ReadLine();

Console.WriteLine($"O celular está ligado? Responda 's' ou 'n': ");
string resposta = Console.ReadLine().ToLower();

if (resposta == "s")
{
    novoCel.ligado = true;
    novoCel.Ligar();
    novoCel.EnviarMensagem();
    novoCel.FazerLigacao();
    novoCel.Desligar();
}
else
{
    novoCel.ligado = false;
}