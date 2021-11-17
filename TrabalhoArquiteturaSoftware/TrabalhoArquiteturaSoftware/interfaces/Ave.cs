using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoArquiteturaSoftware {
    interface IAve {
        public bool PossuiPenas { get; set; }

        void Voar();

        void BotarOvo();

        void Andar();
    }
}