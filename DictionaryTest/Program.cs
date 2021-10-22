using System;

namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // массивы
            string[] rus = new[] { "чай", "какао", "кофе", "творог", "йогурт", "резать", "ветчина", "салат", "сыр", "рыба", "рис", "сок", "яблоко", "пирог" };



            string[] deutsch = new[] {  };
            
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
