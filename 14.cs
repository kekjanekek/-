using System.Linq;
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //contains
            string word = "Hello";
            Console.WriteLine(word.Contains("oll"));
            // если строка содержит подстраку lo то вывести на консоль success
            if (word.Contains("lo") == true)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("NO");
            }
            char[] example = { 'a', '.', '0' };
            Console.WriteLine(example.Contains('a'));
            char[] punc = new char[] { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };//new char[] можно не писать 
            char x = 'a';
            if (punc.Contains(x))
            {
                Console.WriteLine("The symbool is punc");
            }
            else
            {
                Console.WriteLine("it is not punc");
            }


            //Replace
            string text = "Cat dog love";
            string text1 = text.Replace("dog", "more cats");
            Console.WriteLine(text.Replace("dog", "more cats"));// 1 это что меняем, 2 на что меняем. если несколько одинаковых элементов то заменяется все 


            //Trim 
            string word2 = "  cat  ";//удаляем только крайние символы, если захотим убрать т то не получится тк не крайний 
            string word3 = "cat";
            Console.WriteLine(word2.Contains(word));
            word2 = word2.Trim(new char[] { ' ', 't' });//очень удобно 
            Console.WriteLine(word2);


            //Split
            string text2 = "Hello, my dear 2 friends";
            string[] dirtywords = text2.Split(' ');//берет текст и делит его по каким то параметрам 
            foreach (string w in dirtywords)//for (int i = 0; i < dirtywords.Lenght;  i++)
            {
                Console.WriteLine(w);
            }


            //Join 
            string text3 = String.Join(" ", dirtywords);
            Console.WriteLine(text3);


            //IsDigit/ IsLetter
            char s = 'a';
            Console.WriteLine(Char.IsDigit(s));//буллевое
            Console.WriteLine(Char.IsLetter(s));
            Console.WriteLine(Char.IsLetterOrDigit(s));//пиши Char.Is и дальше смотри что предлагают
            //вообще надо для проверок


            //ToUpper/ ToLower 
            string word4 = "Hello";
            Console.WriteLine(word4.ToUpper());//главное сохранить это где то 

            string vowels = "уеоаыяиюё";
            vowels += vowels.ToUpper();
            Console.WriteLine(vowels);

            //абстрактные методы можно заполнять шаблонами какими то 

            //вынести в массив все слова в тексте 
            string input = "Hello, my dear 2 friends";
            string[] dyrtiwords = input.Split(' ');
            for (int i = 0; i < dyrtiwords.Length; i++)
            {
                string trimWord = dyrtiwords[i].Trim(punc);
                Console.WriteLine(trimWord);
            }

        }
    }
}