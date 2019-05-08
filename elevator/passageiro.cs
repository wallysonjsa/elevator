using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace elevator
{
    /// <summary>
    /// Classe que possui atributos encapsulados da entidade passageiro
    /// </summary>
    class passageiro
    {
        private int idPassageiro;
        private int andarOrigem;
        private int andarDestino;

        public int AndarOrigem { get => andarOrigem; set => andarOrigem = value; }
        public int AndarDestino { get => andarDestino; set => andarDestino = value; }
        public int IdPassageiro { get => idPassageiro; set => idPassageiro = value; }

        public passageiro()
        {
            //Inicializa negativo para validação ser efetiva
            andarDestino = int.MaxValue * -1;
            andarOrigem = int.MaxValue * -1;
        }

        public passageiro(int _idPassageiro, int _andarOrigem, int _andarDestino)
        {
            this.idPassageiro = _idPassageiro;
            this.andarOrigem = _andarOrigem;
            this.andarDestino = _andarDestino;
        }
    }
}
