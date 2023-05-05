using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace elevator_poo
{
    public class Elevador
    {
        //propriedades
        public int andarAtual;
        public int totalAndares;
        public int capacidade;
        public int qntdPessoas;

        //métodos
        public Elevador(int capacidade, int totalAndares)
        {
            this.andarAtual = 0;
            this.qntdPessoas = 0;

            this.capacidade = capacidade;
            this.totalAndares = totalAndares;
        }

        public void Entrar()
        {
            Console.WriteLine($"Quantas pessoas se encontram no elevador?");
            qntdPessoas = int.Parse(Console.ReadLine());
            
            if (qntdPessoas < 12)
            {
                qntdPessoas ++;
                Console.WriteLine($"Entre! Agora há {qntdPessoas} pessoas no elevador");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O elevador já está cheio!");
                Console.ResetColor();
            }
        }

        public void Sair()
        {
            Console.WriteLine($"Quantas pessoas se encontram no elevador?");
            qntdPessoas = int.Parse(Console.ReadLine());

            if (qntdPessoas > 0)
            {
                qntdPessoas --;
                Console.WriteLine($"Agora possuem {qntdPessoas} pessoas no elevador");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não é possível remover pessoas porque o elevador está vazio!");
                Console.ResetColor();
            }
        }

        public void Subir()
        {
            Console.WriteLine($"Em que andar se encontra?");
            andarAtual = int.Parse(Console.ReadLine());

            if (andarAtual < 15)
            {
                Console.WriteLine($"Quantos andares deseja subir?");
                int andares = int.Parse(Console.ReadLine());

                if (andarAtual + andares <= 15)
                {
                    Console.WriteLine($"O elevador agora se encontra no {andarAtual + andares}º andar.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Não é possível realizar esta operação!");
                    Console.ResetColor();
                }
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Já estamos no último andar!");
                Console.ResetColor();
            }
        }

        public void Descer()
        {
            Console.WriteLine($"Em que andar se encontra?");
            andarAtual = int.Parse(Console.ReadLine());

            if (andarAtual > 0)
            {
                Console.WriteLine($"Quantos andares deseja descer?");
                int andares = int.Parse(Console.ReadLine());

                if (andarAtual - andares >= 0)
                {
                    Console.WriteLine($"O elevador agora se encontra no {andarAtual - andares}º andar.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Não é possível realizar esta operação!");
                    Console.ResetColor();
                }
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Já estamos no térreo!");
                Console.ResetColor();
            }
        }
    }
}