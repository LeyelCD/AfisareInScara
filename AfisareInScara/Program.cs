using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfisareInScara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "input.txt";

            var wordArrays = new System.Collections.Generic.List<string>[26];
            for (int i = 0; i < 26; i++)
            {
                wordArrays[i] = new System.Collections.Generic.List<string>();
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (!string.IsNullOrEmpty(word))
                        {
                            int index = char.ToUpper(word[0]) - 'A';
                            if (index >= 0 && index < 26)
                            {
                                wordArrays[index].Add(word);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < 26; i++)
            {
                char letter = (char)('A' + i);
                foreach (string word in wordArrays[i])
                {
                    Console.WriteLine(word);
                }
            }
            Console.ReadKey();
        }
    }
}
