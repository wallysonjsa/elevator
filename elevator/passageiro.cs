﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace elevator
{
    class passageiro
    {
        int idPassageiro;
        int andarOrigem;
        int andarDestino;

        public passageiro()
        {
            andarDestino = int.MaxValue*-1;
            andarOrigem = int.MaxValue*-1;
        }

        public int AndarOrigem { get => andarOrigem; set => andarOrigem = value; }
        public int AndarDestino { get => andarDestino; set => andarDestino = value; }
        public int IdPassageiro { get => idPassageiro; set => idPassageiro = value; }
    }
}
