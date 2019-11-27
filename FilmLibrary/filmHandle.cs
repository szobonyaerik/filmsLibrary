using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class filmHandle
    {
        public static string filmsByTitle()
        {
            StringBuilder sr = new StringBuilder();
            var filmDictionaryes = FileHandling.ReadFromFile("../../testFilms.ini");
            Console.Write("Give me the film Title: ");
            string title = Console.ReadLine();
            if (filmDictionaryes.ContainsKey("[" + title + "]"))
            {
                var thefilm = filmDictionaryes["[" + title + "]"];
                string result = $"Title = {title}\nDirector = {thefilm["director"]},\nRelease year = {thefilm["release_year"]}\nStars = {thefilm["stars"]}\nBudget = {thefilm["budget"]}\n";

                return result;
            }
            else
            {
                return "This film is not in the file.";
            }




        }
        public static void displayFilms()
        {
            var filmDictionaryes = FileHandling.ReadFromFile("../../testFilms.ini");

            foreach (var title in filmDictionaryes.Keys)
            {
                var thefilm = filmDictionaryes[title];
                string result = $"Title = {title}\nDirector = {thefilm["director"]}" +
                    $",\nRelease year = {thefilm["release_year"]}\nStars = {thefilm["stars"]}\nBudget = {thefilm["budget"]}\n";

                Console.WriteLine(result);
            }

        }
        public static Dictionary<string, Dictionary<string, string>> addFilm()
        {
            Dictionary<string, Dictionary<string, string>> filmDictionary = FileHandling.ReadFromFile("../../testFilms.ini");
            Dictionary<string, string> oneField = new Dictionary<string, string>();
            string[] keywords = { "director", "release_year", "stars", "budget" };
            Console.Write("Give me the film Title: ");
            string title = "[" + Console.ReadLine() + "]";
            foreach (string element in keywords)
            {
                Console.Write($"Give me the {element}: ");
                oneField.Add(element, Console.ReadLine());
            }
            filmDictionary.Add(title, oneField);
            return filmDictionary;



        }
        public static Dictionary<string, Dictionary<string, string>> deleteFilmByTitle()
        {
            var filmDictionaryes = FileHandling.ReadFromFile("../../testFilms.ini");
            Console.Write("Give me the film Title: ");
            string title = "[" + Console.ReadLine() + "]";
            if (filmDictionaryes.ContainsKey(title))
            {
                filmDictionaryes.Remove(title);
                return filmDictionaryes;
            }
            else
            {
                return filmDictionaryes;
            }
        }
    }

}
