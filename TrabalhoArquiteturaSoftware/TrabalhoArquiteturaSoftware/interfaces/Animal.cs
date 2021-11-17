using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoArquiteturaSoftware {
    interface IAnimal {
        public string Cor { get; set; }

        public string Especie { get; set; }

        public int QuantidadeMembros { get; set; }

        void Comer();

        void Dormir();

        void SeReproduzir();
    }
}
