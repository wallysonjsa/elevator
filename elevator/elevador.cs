using System;

namespace elevator
{
    class elevador
    {
        private int idElevador;
        private int andarCorrente;
        private int andarDestino;
        private int tempoMovimento;
        private string statusElevador;
        private string statusDirecao;
        private int ultimoAndar;

        public int IdElevador { get => idElevador; set => idElevador = value; }
        public int AndarCorrente { get => andarCorrente; set => andarCorrente = value; }
        public int AndarDestino { get => andarDestino; set => andarDestino = value; }
        public int TempoMovimento { get => tempoMovimento; set => tempoMovimento = value; }
        public string StatusElevador { get => statusElevador; set => statusElevador = value; }
        public string StatusDirecao { get => statusDirecao; set => statusDirecao = value; }
        public int UltimoAndar { get => ultimoAndar; set => ultimoAndar = value; }

        public elevador()
        {
            tempoMovimento = 2;
            andarDestino = int.MaxValue*-1;
            andarCorrente = int.MaxValue*-1;
            ultimoAndar = int.MaxValue*-1;
        }

    }
}
