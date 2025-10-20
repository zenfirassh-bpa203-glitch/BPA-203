using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace StringTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I am Backend DEVELOPER I LEARN C#";

            // 1. Sait hərflərin tapılması
            Console.WriteLine("1. Sait hərflər:");
            string saitler = "aeiouAEIOU";
            foreach (char c in sentence)
            {
                if(saitler.IndexOf(c) >= 0 && Char.IsLetter(c))
                {
                    Console.Write(c + " ");
                }
            }

            // 2. Sözlərin boşluğa görə sayı
            string[] words = sentence.Split(' ');
            int wordCount = 0;
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    wordCount++;
                }
            }
            Console.WriteLine("Sözlərin sayı: " + wordCount);

            // 3. Ən uzun söz
            string longestWord = "";
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word) && word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine("Ən uzun söz: " + longestWord);

            // 4. Bütün hərfləri böyük olan sözlər və indeksləri
            Console.WriteLine("Bütün hərfləri böyük olan sözlər və indeksləri:");
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (IsAllUpper(word))
                {
                    Console.WriteLine("Söz: " + word + ", İndeks: " + i);
                }
            }

            // 5. 2-dən artıq böyük hərfi olan sözlər
            Console.WriteLine("2-dən artıq böyük hərfi olan sözlər:");
            foreach (string word in words)
            {
                int upperCount = 0;
                foreach (char c in word)
                {
                    if (Char.IsUpper(c))
                    {
                        upperCount++;
                    }
                }

                if (upperCount > 2)
                {
                    Console.WriteLine(word);
                }
            }
        }

        // Bu metod bütün hərfləri böyük olan sözləri yoxlayır
        static bool IsAllUpper(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return false;

            foreach (char c in word)
            {
                if (Char.IsLetter(c) && !Char.IsUpper(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
