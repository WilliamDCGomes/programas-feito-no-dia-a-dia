using System;
using System.Collections.Generic;

namespace Ordena {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, int> peolpe = new Dictionary<string, int>();
            Console.WriteLine("Enter with the quantity of people that you want:");
            int quantityPeople = int.Parse(Console.ReadLine());
            for(int i = 0;i < quantityPeople; i++) {
                Console.WriteLine("Enter with the name of the person and the votes: ex:(name,votes)");
                string[] input = Console.ReadLine().Split(",");
                string name = input[0];
                int voteQuantity = int.Parse(input[1]);
                if (peolpe.ContainsKey(name)) {
                    peolpe[name] += voteQuantity;
                } 
                else {
                    peolpe[name] = voteQuantity;
                }
            }
            Console.WriteLine("Result");
            foreach(var i in peolpe) {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }
    }
}
