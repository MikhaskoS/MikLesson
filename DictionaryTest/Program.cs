using System;

namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // массивы
            string[] rus = new[] { "грустный", "спокойный","активный","романтичный","дикий","уставший","веселый","злой"};
            string[] deutsch = new[] { "traurig", "ruhig","aktiv","romantisch","wild", "mude","froh", "bose" };
            Word[] words = new Word[rus.Length];

            // заполняем массив
            for (int i = 0; i < words.Length; i++)
            {
                Word word = new Word()
                {
                    TextRus = rus[i],
                    TextTranslation = deutsch[i]
                };

                words[i] = word;
            }


            //foreach (Word w in words)
            //    Console.WriteLine(w.TextTranslation);

            bool res = true;
            int q = 0;
            while(res)
            {
                if (words[q].attempt >= 0)
                {
                    Console.WriteLine($"Перевод слова {words[q].TextRus} : ");
                    string translate = Console.ReadLine();

                    if (translate == words[q].TextTranslation)
                    {
                        Console.WriteLine("Верно!");
                        words[q].attempt = words[q].attempt - 1;
                    }
                    else
                    {
                        Console.WriteLine("Неверно!");
                        words[q].attempt = words[q].attempt + 1;
                    }
                }

                q++;
                if (q > words.Length - 1) q = 0;
            }


            Console.ReadLine();
        }
    }
}
