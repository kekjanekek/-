using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объект для сериалезации
            Movie movie1 = new Movie("Breaking bad", 150);
            MovieDTO movieDTO = new MovieDTO(movie1.Name, movie1.Duration);


            //создаем путь для файла xml на рабочий стол
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(folderPath, "movie.xml");

            //создаем xml-сериализатор
            //-класс должен иметь конструктор без параметров 
            //- класс должен быть публичным 
            //- в классе все свойства должны быть с публичными get set
            //тк будет нарушаться то создаем доп класс (ДТО)

            //оригинальный объект -> ДТО объект -> отдать все в сериализатор 
            //десериализуем объект 
            var serializer = new XmlSerializer(typeof(MovieDTO));
            using (var writer = new StreamWriter(filePath)) //поток 
            {
                serializer.Serialize(writer, movieDTO);//1 место поток 2 место точ то передаем( передаем только дто)
            }
            //десериализуем объект из файла -> получаем файл ДТО объект -> оригинальный объект 
            MovieDTO movieDTO2;
            using (var reader = new StreamReader(filePath))
            {
                movieDTO2 = (MovieDTO)serializer.Deserialize(reader);
            }
            Movie movie2 = new Movie(movieDTO2.Name, movieDTO2.Duration);
        }



        private static bool CompareMovies(Movie m1, Movie m2)
        {
            if (m1.Name != m2.Name) return false;
            if (m1.Duration != m2.Duration) return false;
            

            return true;
        }

        public class Movie
        {
            private string _name;
            private int _duration;
            private int[] _rating;

            public string Name => _name;
            public int Duration => _duration;
            public int[] Rating => _rating;

            public Movie(string name, int duration)
            {
                _name = name;
                _duration = duration;
                _rating = new int[0];
            }

            public void Add(int stars)
            {
                Array.Resize(ref _rating, _rating.Length + 1);
                _rating[_rating.Length  - 1] = stars;

            }
        }

        public class MovieDTO
        {
            public string Name { get; set; }
            public int Duration { get; set; }

            public MovieDTO()
            {
            }

            public MovieDTO(string name, int duration)
            {
                Name = name;
                Duration = duration;
            }
            public MovieDTO(Movie movie)
            {
                Name = movie.Name;
                Duration = movie.Duration;
            }



        }
    }

}
