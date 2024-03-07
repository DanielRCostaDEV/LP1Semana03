using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write a sentence or a word: ");
            string str = Console.ReadLine();

            Console.Write("Please insert a character to be replaced: ");
            char c = char.Parse(Console.ReadLine());
        }
    }
}
