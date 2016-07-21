using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTry
{
    class Program
    {
        static void Main(string[] args)

        {
            List<String> words = new List<string>();

            while (true)
            {
                Console.WriteLine("Type a word: ");
                string answer = Console.ReadLine();
                words.Add(answer);
                if (answer.Equals(""))
                {
                    words.Reverse();
                    Console.WriteLine("You typed the following words:  ");
                    foreach (string word in words)
                    {
                        Console.WriteLine(word);
                        
                    }
                    break;
                }



            }

            Console.ReadKey();

        }
    }
}
