using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Word> Letters = new List<Word>();
            List<char> LetterComp = new List<char>();
            Console.WriteLine("Tap the name that you want");
            string name = Console.ReadLine().ToUpper();
            for(int i = 0; i < name.Length; i++)
            {
                if (LetterComp.Contains(name[i]))
                {
                    foreach (Word letter in Letters)
                    {
                        if (letter.Letter.Equals(name[i]))
                        {
                            letter.AddQuantity();
                            break;
                        }
                    }
                }
                else
                {
                    Word word = new Word(name[i]);
                    LetterComp.Add(name[i]);
                    Letters.Add(word);
                    word.AddQuantity();
                }
            }
            Console.WriteLine("Result:");
            foreach(Word result in Letters)
            {
                Console.WriteLine($"{result.Letter}: {result.Quantity}");
            }
        }
    }
}
