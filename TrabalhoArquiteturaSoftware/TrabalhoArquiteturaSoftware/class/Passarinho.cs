using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoArquiteturaSoftware {
    class Passarinho : IAnimal, IAve {
        public string Cor { get => Cor; set => Cor = value; }
        public string Especie { get => Especie; set => Especie = Especie; }
        public int QuantidadeMembros { get => QuantidadeMembros; set => QuantidadeMembros = value; }
        public bool PossuiPenas { get => PossuiPenas; set => PossuiPenas = value; }

        public void Comer() {
            Console.WriteLine("Passarinho Comendo");
        }

        public void Dormir() {
            Console.WriteLine("Passarinho Dormindo");
        }

        public void SeReproduzir() {
            Console.WriteLine("Passarinho se Reproduzindo");
        }

        public void Voar() {
            Console.WriteLine("Passarinho Voando");
        }

        public void Andar() {
            Console.WriteLine("Passarinho Andando");
        }

        public void BotarOvo() {
            Console.WriteLine("Passarinho Botando ovo");
        }

        public void FazerSom() {
            Console.WriteLine("Passarinho Pia");
        }
    }
}
