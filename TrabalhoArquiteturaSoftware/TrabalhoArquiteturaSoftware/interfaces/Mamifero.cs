using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoArquiteturaSoftware {
    interface IMamifero {
        public bool PossuiPelos { get; set; }

        void DarLuz();

        void Andar();
    }
}