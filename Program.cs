using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum/Min/Max/Count
            int[] num = { 1, 2, 3, 4 };
            Console.WriteLine(num.Sum());

            string[] words = { "hello", "my", "friend" };
            int result = words.Sum(x => x.Length);//=> это лябмда выражение 
            int result2 = words.Count(x => x.Length % 2 == 0);//булевое значение тру 

            Example[] examples = new Example[3];
            for (int i = 0;i<3;i++)
            {
                examples[i] = new Example(i);
            }
            result = examples.Sum(x => x.Num);


            //Any, All
            bool f1 = words.Any(x => x.Length % 3 == 0);
            bool f2 = words.All(x => x.Length > 1);


            //Select, Where, GroupBy возвращает тип группу , Distinct убирает дубликаты 
            int[] wordsLenght = words.Select(x =>  x.Length).ToArray();//из одного масива в другой, то эрй обязательно тк из масива в другой масив 
            string[] longWords = words.Where(x => x.Length>2).ToArray();
            int[] wordsResult = words.Select(x => x.Length)//можно в одну строчку а можно в несколько без разницы 
                                        .Where(x => x >2)
                                        .ToArray();
            string word = "hello123";
            char[] wordChars = word.ToCharArray();
            bool f = word.Any(x => char.IsDigit(x));

        }
        public struct Example
        {
            private int _num;
            public int Num => _num;

        }
        public int Example(string x)
        {
            return x.Length;
        }
        

       
    }
}
