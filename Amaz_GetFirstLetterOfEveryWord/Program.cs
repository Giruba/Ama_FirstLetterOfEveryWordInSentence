using System;

namespace Amaz_GetFirstLetterOfEveryWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get First Letter of Every Word In A Sentence!");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Enter a sentence");
            try
            {
                String sentence = Console.ReadLine();
                PrintFirstLetterOfEveryWord(sentence);
            }
            catch (Exception exception) {
                Console.WriteLine("Exception thrown is "+exception.Message);
            }

            Console.ReadLine();
        }


        private static void PrintFirstLetterOfEveryWord(String sentence) {

            try
            {
                Char[] array = sentence.ToCharArray();
                String result = ""+array[0];
                result.Trim();
                for (int i = 1; i < array.Length; i++) {
                    if (Char.IsWhiteSpace(array[i]) && !Char.IsWhiteSpace(array[i + 1]))
                    {
                        result += array[i + 1];
                        i += 1;
                    }
                    else {
                        continue;
                    }
                }
                Console.WriteLine(result);
            }
            catch (Exception exception) {
                Console.WriteLine("Exception thrown is "+exception.Message);
            }
        }
    }
}
