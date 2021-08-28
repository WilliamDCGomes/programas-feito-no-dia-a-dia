using System;
using System.Collections.Generic;
namespace conversor_dart_to_json{
    class Program    {
        static void Main(string[] args){
            while (true){
                Console.WriteLine("Nome Classe:");
                string className = Console.ReadLine();
                List<string> variables = new List<string>();
                Console.WriteLine("Digite as Variáveis:");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                        break;
                    variables.Add(input);
                }
                Console.WriteLine($"{className}.fromJson(Map<String, dynamic> json) {{");
                variables.ForEach(va => Console.WriteLine($"  {va} = json[\"{va.Substring(0, 1).ToLower() + va.Remove(0, 1)}\"];"));
                Console.WriteLine("}\n");
                Console.WriteLine("Map<String, dynamic> toJson() {");
                Console.WriteLine("final Map<String, dynamic> data = new Map<String, dynamic>();");
                variables.ForEach(va => Console.WriteLine($"  data[\"{va.Substring(0, 1).ToLower() + va.Remove(0, 1)}\"] = this.{va};"));
                Console.WriteLine("  return data;");
                Console.WriteLine("}");
                Console.WriteLine("\nToque qualquer tecla para converter outra classe");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}