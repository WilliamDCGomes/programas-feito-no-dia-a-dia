using System;
using System.Collections.Generic;
using System.Linq;

namespace conversor_dart_to_json{
    class Program    {
        static void Main(string[] args){
            while (true){
                List<string> variables = new List<string>();
                List<string> variablesFromBanco = new List<string>();
                List<string> variablesFromBancoAux = new List<string>();
                Console.WriteLine("Cole o banco");
                string database = "";
                while (true)
                {
                    string inputdb = Console.ReadLine();
                    database += inputdb + "\n";
                    if (string.IsNullOrEmpty(inputdb))
                        break;
                }
                Console.Clear();
                Console.WriteLine("BANCO COM TO UPPER\n");
                Console.WriteLine(database.ToUpper());
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Nome Classe:");
                string className = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("Digite o Campo do banco:");
                    string inputbanco = Console.ReadLine();                    
                    if (string.IsNullOrEmpty(inputbanco))
                        break;
                    Console.WriteLine("Digite a Variável:");
                    string input = Console.ReadLine();
                    variables.Add(input);
                    variablesFromBanco.Add(inputbanco);
                    variablesFromBancoAux.Add(inputbanco);
                }
                Console.WriteLine("//#region Conversões");
                Console.WriteLine($"{className}.fromJson(Map<String, dynamic> json) {{");
                int aux = 0;
                foreach(string va in variables)
                {
                    Console.WriteLine($"  {va} = json[\"{variablesFromBanco.FirstOrDefault()}\"];");
                    if(variablesFromBanco.Count() > 0)
                        variablesFromBanco.RemoveAt(0);
                }
                Console.WriteLine("}\n");
                Console.WriteLine("Map<String, dynamic> toJson() {");
                Console.WriteLine("final Map<String, dynamic> data = new Map<String, dynamic>();");
                foreach (string va in variables)
                {
                    Console.WriteLine($"  data[\"{variablesFromBancoAux.FirstOrDefault()}\"] = this.{va};");
                    if (variablesFromBancoAux.Count() > 0)
                        variablesFromBancoAux.RemoveAt(0);
                }
                Console.WriteLine("  return data;");
                Console.WriteLine("}");
                Console.WriteLine("//#endregion");
                Console.WriteLine("\nToque qualquer tecla para converter outra classe");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}