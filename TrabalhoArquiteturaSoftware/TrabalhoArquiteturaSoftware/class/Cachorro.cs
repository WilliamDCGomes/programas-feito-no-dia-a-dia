using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoArquiteturaSoftware{
    class Cachorro : IAnimal, IMamifero {
        public string Cor { get => Cor; set => Cor = value; }
        public string Especie { get => Especie; set => Especie = Especie; }
        public int QuantidadeMembros { get => QuantidadeMembros; set => QuantidadeMembros = value; }
        public bool PossuiPelos { get => PossuiPelos; set => PossuiPelos = value; }

        public void Andar() {
            Console.WriteLine("Cachorro Andando");
        }

        public void Comer() {
            Console.WriteLine("Cachorro Comendo");
        }

        public void Dormir() {
            Console.WriteLine("Cachorro Dormindo");
        }

        public void SeReproduzir() {
            Console.WriteLine("Cachorro se Reproduzindo");
        }

        public void DarLuz() {
            Console.WriteLine("Cachorro dando a Luz");
        }

        public void FazerSom() {
            Console.WriteLine("Cachorro Latindo");
        }
    }
}
