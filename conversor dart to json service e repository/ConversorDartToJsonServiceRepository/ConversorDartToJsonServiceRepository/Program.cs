using System;
using System.Collections.Generic;

namespace ConversorDartToJsonServiceRepository
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Cole a Conversão já pronta");
                string input = "";
                string className = "";
                List<string> inputs = new List<string>();
                List<string> variables = new List<string>();
                while (true)
                {
                    input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                        break;
                    if (input.Contains("//#region") || input.Contains("// #region"))
                        input = "//#region Repository";
                    if (input.Contains(".fromJson"))
                    {
                        className = input.Substring(0, input.IndexOf("."));
                        input = input.Replace(".fromJson", ".fromJsonRepository");
                    }
                    if (input.Contains(".toJson"))
                        input = input.Replace(".toJson", ".toJsonRepository");
                    if (input.Contains("data["))
                    {
                        int begin = input.IndexOf(".") + 1;
                        int end = input.IndexOf(";") - begin;
                        variables.Add(input.Substring(begin, end));
                    }
                    inputs.Add(input);
                }
                Console.Clear();
                Console.WriteLine("//#region Conversões");
                Console.WriteLine("  //#region Conversão Service");
                Console.WriteLine($"  {className}.fromJsonService(Map<String, dynamic> json) {{");
                variables.ForEach(va => Console.WriteLine($"    {va} = json[\"{va.Substring(0, 1).ToLower() + va.Remove(0, 1)}\"];"));
                Console.WriteLine("  }\n");
                Console.WriteLine("  Map<String, dynamic> toJsonService() {");
                Console.WriteLine("  final Map<String, dynamic> data = new Map<String, dynamic>();");
                variables.ForEach(va => Console.WriteLine($"    data[\"{va.Substring(0, 1).ToLower() + va.Remove(0, 1)}\"] = this.{va};"));
                Console.WriteLine("    return data;");
                Console.WriteLine("  }");
                Console.WriteLine("  //#endregion\n");
                inputs.ForEach(i => Console.WriteLine($"  {i}"));
                Console.WriteLine("//#endregion");
                Console.WriteLine("\nToque qualquer tecla para converter outra classe");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
