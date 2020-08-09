using System;
using System.IO;
using System.Collections.Generic;

namespace Programa_que_tira_parte_de_um_texto {
    class Program {
        static void Main(string[] args) {
            while (true) {
                List<string> inputBaseList = new List<string>();
                Console.WriteLine("Insira o texto base:");
                while (true) {
                    string inputBase = Console.ReadLine();
                    if (string.IsNullOrEmpty(inputBase)) {
                        break;
                    }
                    inputBaseList.Add(inputBase);
                }
                List<string> inputRemoveList = new List<string>();
                Console.WriteLine("\nInsira o texto que irá remover:");
                while (true) {
                    string inputRemove = Console.ReadLine();
                    if (string.IsNullOrEmpty(inputRemove)) {
                        break;
                    }
                    inputRemoveList.Add(inputRemove);
                }
                List<string> output = new List<string>();
                foreach (String i in inputBaseList) {
                    bool entrou = false;
                    foreach (String j in inputRemoveList) {
                        if (i.Equals(j)) {
                            entrou = true;
                            break;
                        }
                    }
                    if (entrou == false) {
                        output.Add(i);
                    }
                }
                string targetPath = @"C:\Users\willi\Desktop\Arquivo de Saída.txt";
                try {
                    using (StreamWriter sw = File.AppendText(targetPath)) {
                        sw.WriteLine($"Total de linhas: {output.Count}".ToUpper());
                        foreach (string line in output) {
                            sw.WriteLine(line.ToUpper());
                        }
                        sw.WriteLine("\n\nWilliamDCGomes".ToUpper());
                    }
                    Console.WriteLine("Arquivo de saída criado com sucesso");
                    Console.WriteLine("Endereço:");
                    Console.WriteLine(targetPath);
                }
                catch (IOException e) {
                    Console.WriteLine("Um erro ocorru na hora gerar o arquivo de saída!");
                    Console.WriteLine(e.Message);
                }
                int inp;
                while (true) {
                    Console.WriteLine("\n\nDeseja gerar outro?\n(1) Sim\n(2) Não");
                    inp = int.Parse(Console.ReadLine());
                    if (inp == 1 || inp==2) {
                        Console.Clear();
                        break;
                    }
                    else {
                        Console.WriteLine("Opção inválida!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                if (inp == 2) {
                    Console.WriteLine("Obrigado por utilizar o programa!\n");
                    break;
                }
            }
        }
    }
}
