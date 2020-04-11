using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_capital_letters_into_small
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] sentence = new char [100];
            //string[] sentence = new string[100];
            Console.Write("Enter a Sentence : ");
            string letter = (Console.ReadLine());
            for (int i = 0; i < letter.Length ; i++)
            {
                if (letter[i] >= 'a' && letter[i] <= 'z')
                {
                    sentence[i] = (char)((int)(letter[i] - 32));
                }
                else if (letter[i] >= 'A' && letter[i] <= 'Z')
                {
                    sentence[i] = (char)((int)(letter[i] + 32));
                }
                else
                {
                    sentence[i] = letter[i];    
                } 
            }
            Console.WriteLine();
            Console.WriteLine(sentence) ;
        }
    }
}
