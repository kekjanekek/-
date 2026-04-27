using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;//проект нагет внизу

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //получение путей к папкам 

            //абсалютный пусть (начиная прям с диска и дальше в папки и тд)актуален для конкретного компьютера 


            //относительный путь (Relative path)"data.txt" название файла "dadaset/data.txt"

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//записывает в переменную путь к рабочему столу на этом компе
            Console.WriteLine(folderPath);
            //string filePath = Path.Combine(folderPath, "Test", "example.txt");//создаем файл 

            string folderPath1 = Path.Combine(folderPath, "Test");
            string filePath = Path.Combine(folderPath, "Test", "example.txt");

            //if (File.Exists(filePath))
            /*{
                Console.WriteLine("существует на компе");
            }
            else
            {
                Console.WriteLine("не сущ на компе");
                //надо закрывать обязательно потоки
                File.CreateText(filePath).Close();
            }*/

            if(Directory.Exists(folderPath1))
            {
                Console.WriteLine("u have papka");
            }
            else
            {
                Console.WriteLine("u dont have papka");
                Directory.CreateDirectory(folderPath1);
            }
            string fileNameCheck = Path.GetFileName(filePath);
            File.WriteAllText(filePath, "hihihi");
            File.WriteAllLines(filePath, new string[] {"hi", "hi", "hi" });

            File.AppendAllText(filePath, "");
            File.AppendAllLines(filePath, new string[] { "emae", "hi" });//добавка



        }

        public class Movie
        {
            private string _name;
            private int _duration;
            private int[] _rewiew;

            public Movie(string name, int duration)
            {
                _name = name;
                _duration = duration;
                _rewiew = new int[0];

            }
            public void Add(int num)
            {
                Array.Resize(ref _rewiew, num);
                _rewiew[_rewiew.Length - 1] = num;
            }
          
        }

    }
}
