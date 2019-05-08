using System;
using System.Collections.Generic;

namespace elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Valores vars = new Valores();
            elevador e1 = new elevador();

            //Lista do tipo da classe passageiro
            List<passageiro> passageiro = new List<passageiro>();



            //Inicializa negativo para validação ser efetiva
            int qtdPassageiro = -1;

            //Enquando o não for um valor positivo, continuar solicitando ao usuário
            bool ex1 = false;

            while (e1.UltimoAndar <= 0 || ex1)
            {
                Console.WriteLine(vars.informeQtd + " de ANDARES do predio" + vars.fimTexto);

                //Tratamento de exceção para não aceitar letras usando variável boleana ex1
                try {
                    e1.UltimoAndar = int.Parse(Console.ReadLine());
                }catch{ ex1 = true; }

                //Não aceitar valor negativo ou letras
                if (e1.UltimoAndar <= 0 || ex1)
                {
                    Console.WriteLine(vars.andaresPredio + int.MaxValue);
                    ex1 = false;
                }
            }

            //Range de andares válidos
            string rangeAndares = vars.terreo + e1.UltimoAndar + ")";

            //Enquando o não for um valor positivo, continuar solicitando ao usuário
            ex1 = false;
            while (e1.AndarCorrente < 0 || e1.AndarCorrente > e1.UltimoAndar || ex1)
            {
                Console.WriteLine(vars.andarAtual + " que o elevador está parado" + rangeAndares + vars.fimTexto);

                //Tratamento de exceção para não aceitar letras usando variável boleana ex1
                try
                {
                    e1.AndarCorrente = int.Parse(Console.ReadLine());
                }
                catch{ ex1 = true; }

                //Não aceitar valor negativo, andar corrente maior que o último andar ou letras
                if (e1.AndarCorrente < 0 || e1.AndarCorrente > e1.UltimoAndar || ex1)
                {
                    Console.WriteLine(vars.informeAndarvalido + e1.UltimoAndar + vars.ultimoAndar);
                    ex1 = false;
                }
            }

            //Enquando o não for um valor positivo, continuar solicitando ao usuário
            ex1 = false;
            while (qtdPassageiro <= 0 || ex1)
            {
                Console.WriteLine(vars.informeQtd + " de passageiros" + vars.fimTexto);

                //Tratamento de exceção para não aceitar letras usando variável boleana ex1
                try
                {
                    qtdPassageiro = int.Parse(Console.ReadLine());
                }
                catch { ex1 = true; }

                //Não aceitar valor negativo ou letras
                if (qtdPassageiro<= 0 || ex1)
                {
                    Console.WriteLine(vars.andaresPredio + int.MaxValue);
                    ex1 = false;
                }
            }

            //Loop para solicitar X vezes de passageiros for informado pelo usuário
            for (int x = 0; x < qtdPassageiro; x++)
            {
                passageiro p1 = new passageiro();

                int idP = x + 1;
                p1.IdPassageiro = idP;
                p1.AndarDestino = int.MaxValue*-1;
                p1.AndarOrigem = int.MaxValue * -1;

                //Enquando o não for um valor positivo, continuar solicitando ao usuário um valor válido
                ex1 = false;
                while (p1.AndarOrigem < 0 || p1.AndarOrigem > e1.UltimoAndar || ex1) {
                    Console.WriteLine(vars.informeAndar + " ATUAL do " + vars.passageiro + " " + idP + rangeAndares + vars.fimTexto);

                    //Tratamento de exceção para não aceitar letras usando variável boleana ex1
                    try
                    {
                        p1.AndarOrigem = int.Parse(Console.ReadLine());
                    }
                    catch { ex1 = true; }

                    //Não aceitar valor negativo, andar origem maior que o último andar ou letras
                    if (p1.AndarOrigem < 0 || p1.AndarOrigem > e1.UltimoAndar || ex1)
                    {
                        Console.WriteLine(vars.informeAndarvalido + e1.UltimoAndar + vars.ultimoAndar);
                        ex1 = false;
                    }
                }

                //Enquando o não for um valor positivo, continuar solicitando ao usuário um valor válido
                ex1 = false;
                while (p1.AndarDestino < 0 || p1.AndarDestino > e1.UltimoAndar || p1.AndarOrigem == p1.AndarDestino || ex1)
                {
                    Console.WriteLine(vars.informeAndar + " de DESTINO do " + vars.passageiro + " " + idP + rangeAndares + " (exceto " + p1.AndarOrigem + ")" + vars.fimTexto);

                    //Tratamento de exceção para não aceitar letras usando variável boleana ex1
                    try
                    {
                        p1.AndarDestino = int.Parse(Console.ReadLine());
                    }
                    catch { ex1 = true; }

                    //Não aceitar valor negativo, andar corrente maior que o último andar, andar origem igual ao andar destino ou letras
                    if (p1.AndarDestino < 0 || p1.AndarDestino > e1.UltimoAndar || p1.AndarOrigem == p1.AndarDestino || ex1)
                    {
                        Console.WriteLine(vars.informeAndarvalido + e1.UltimoAndar + vars.ultimoAndar + " (exceto " + p1.AndarOrigem + ")");
                        ex1 = false;
                    }
                }

                //Adiciona os atributos do passageiro na lista
                passageiro.Add(p1);

            }

            //Lista que armazena solicitações para SUBIR
            List<passageiro> lstSubir = new List<passageiro>();

            //Lista que armazena solicitações para DESCER
            List<passageiro> lstDescer = new List<passageiro>();

            //Prepara Solicitações
            for (int x=0; x<passageiro.Count; x++)
            {
                if(passageiro[x].AndarOrigem > passageiro[x].AndarDestino && passageiro[x].AndarOrigem > e1.AndarCorrente)
                {
                    lstDescer.Add(passageiro[x]);
                }

                if (passageiro[x].AndarOrigem < passageiro[x].AndarDestino && passageiro[x].AndarOrigem < e1.AndarCorrente)
                {
                    lstSubir.Add(passageiro[x]);
                }

                if (passageiro[x].AndarOrigem > passageiro[x].AndarDestino && passageiro[x].AndarOrigem < e1.AndarCorrente)
                {
                    lstDescer.Add(passageiro[x]);
                    lstSubir.Add(passageiro[x]);
                }

                if (passageiro[x].AndarOrigem < passageiro[x].AndarDestino && passageiro[x].AndarOrigem > e1.AndarCorrente)
                {
                    lstSubir.Add(passageiro[x]);
                    lstDescer.Add(passageiro[x]);
                }

                //lstDescer.Sort();
                //lstSubir.Sort();
            }

            Console.WriteLine("Fim.");
            Console.Read();
        }
    }
}