using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace elevator
{
    /// <summary>
    /// Classe que possui valores que será reutilizado no código 
    /// visando reduzir consumo de memória com alocamento alocando literais
    /// </summary>
    class Valores
    {
        public string apenasNumeros = "Informe apenas números positivos.";
        public string informeQtd = "Informe a QUANTIDADE";
        public string andarAtual = "Informe o andar ATUAL";
        public string informeAndar = "Informe o andar";
        public string informeAndarvalido = "Informe um andar entre 0 (TÉRREO) e ";
        public string informeAndarEntre = "Informe um andar entre ";
        public string andaresPredio = "Informe um valor entre 1 e ";
        public string passageiro = "passageiro";
        public string ultimoAndar = " (ÚLTIMO ANDAR)";
        public string terreo = " (0=TERRÉO até ";
        public string fimTexto = ": ";
    }
}
