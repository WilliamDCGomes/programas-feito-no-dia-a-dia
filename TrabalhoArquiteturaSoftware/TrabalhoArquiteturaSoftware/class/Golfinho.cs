using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoArquiteturaSoftware{
    class Golfinho : IAnimal, IMamifero {
        public string Cor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Especie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int QuantidadeMembros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PossuiPelos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Andar() {
            Console.WriteLine("Golfinho Andando");
        }

        public void Comer() {
            Console.WriteLine("Golfinho Comendo");
        }

        public void Dormir() {
            Console.WriteLine("Golfinho Dormindo");
        }

        public void DarLuz() {
            Console.WriteLine("Golfinho dando a Luz");
        }

        public void SeReproduzir() {
            Console.WriteLine("Golfinho se Reproduzindo");
        }

        public void FazerSom() {
            Console.WriteLine("Passarinho Pia");
        }
    }
}
