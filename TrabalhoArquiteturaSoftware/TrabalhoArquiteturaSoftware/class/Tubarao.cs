using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoArquiteturaSoftware{
    class Tubarao : IAnimal, IPeixes {
        public string Cor { get => Cor; set => Cor = value; }
        public string Especie { get => Especie; set => Especie = Especie; }
        public int QuantidadeMembros { get => QuantidadeMembros; set => QuantidadeMembros = value; }
        public bool PossuiEscamas { get => PossuiEscamas; set => PossuiEscamas = value; }

        public void BotarOvo() {
            Console.WriteLine("Tubarão botando ovo");
        }

        public void Comer() {
            Console.WriteLine("Tubarão comendo");
        }

        public void Dormir() {
            Console.WriteLine("Tubarão dormindo");
        }

        public void Nadar() {
            Console.WriteLine("Tubarão Nadando");
        }

        public void SeReproduzir() {
            Console.WriteLine("Tubarão se Reproduzindo");
        }
    }
}
