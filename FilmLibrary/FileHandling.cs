using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilmLibrary
{
    public class FileHandling
    {
        public static Dictionary<string, Dictionary<string, string>> ReadFromFile(string FileName)
        {

            Dictionary<string, Dictionary<string, string>> allFilm = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> oneField = new Dictionary<string, string>();
            string keyword = "";
            var file = File.ReadAllLines(FileName);

            for (int i = 0; i < file.Count(); i++)
            {
                if (file[i][0] == '[')
                    keyword = file[i];
                if (file[i].Contains('='))
                {
                    string[] result = file[i].Split('=');
                    oneField.Add(result[0], result[1]);

                }
                if (i < file.Count() - 2 && file[i + 1][0] == '[' || i == file.Count() - 1)
                {
                    allFilm.Add(keyword, oneField);
                    keyword = "";
                    oneField = new Dictionary<string, string>();



                }
            }
            return allFilm;
        }
        public static void writeToFile(string fileName, Dictionary<string, Dictionary<string, string>> filmDictionaries)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var element in filmDictionaries)
                {
                    sw.WriteLine(element.Key);
                    foreach (var el in element.Value)
                    {
                        sw.WriteLine($"{el.Key}={el.Value}");
                    }
                }
            }
        }
    }

}
