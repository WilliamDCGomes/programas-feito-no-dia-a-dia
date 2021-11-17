using System;

namespace TrabalhoArquiteturaSoftware {
    class Program {
        static void Main(string[] args) {
            Cachorro cachorro = new Cachorro();
            Passarinho passarinho = new Passarinho();
            Golfinho golfinho = new Golfinho();
            Tubarao tubarao = new Tubarao();

            cachorro.SeReproduzir();
            passarinho.Voar();
            golfinho.FazerSom();
            tubarao.Nadar();
        }
    }
}
