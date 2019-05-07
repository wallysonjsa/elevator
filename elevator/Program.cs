using System;
using System.Collections.Generic;

namespace elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            strings strs = new strings();
            elevador e1 = new elevador();
            passageiro p1 = new passageiro();
            List<passageiro> passageiro = new List<passageiro>();
            int qtdPassageiro;

            Console.WriteLine(strs.informeQtd + " de ANDARES do predio: ");
            e1.UltimoAndar = int.Parse(Console.ReadLine());

            Console.WriteLine(strs.andarAtual + " que o elevador está parado: ");
            e1.AndarCorrente = int.Parse(Console.ReadLine());

            Console.WriteLine(strs.informeQtd + " de passageiros: ");
            qtdPassageiro = int.Parse(Console.ReadLine());

            for (int x = 0; x < qtdPassageiro; x++)
            {
                int idP = x + 1;
                p1.IdPassageiro = idP;

                Console.WriteLine(strs.andarAtual + " do passageiro " + idP + ": ");
                p1.AndarOrigem = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o andar de DESTINO do passageiro " + idP + ": ");
                p1.AndarDestino = int.Parse(Console.ReadLine());

                passageiro.Add(p1);
            }

            Console.Read();
        }

    }

}
