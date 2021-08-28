using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Word
    {
        public char Letter { get; set; }
        public int Quantity { get; set; }
        public Word(char Letter)
        {
            this.Letter = Letter;
            Quantity = 0;
        }
        public void AddQuantity()
        {
            Quantity++;
        }
    }
}
