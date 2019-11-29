using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class filmHandle
    {
        
        public List<Film> readFilmList(Dictionary<string, Dictionary<string, string>> listOfFilmDictionary)
        {
            List<Film> filmObjectList = new List<Film>();
            
            foreach(var element in listOfFilmDictionary)
            {
                filmObjectList.Add(new Film(element.Key,
                                                element.Value["director"],
                                                Convert.ToInt32(element.Value["release_year"]),
                                                element.Value["stars"],
                                                Convert.ToInt32(element.Value["budget"])));
            }

            return filmObjectList;
        }
        public  string FilmsByTitle(List<Film> FilmList,string title)
        {
            foreach (Film element in FilmList)
            {
                
                if (element.Title == "[" + title + "]")
                {
                    return element.ToString();
                }
            }
            return "There is no such film";
            
                
        }
        public  string displayFilms(List<Film> FilmList)
        {
            string result = "";
            foreach (Film element in FilmList)
            {
                result += element.ToString() + "\n";
            }
            return result;

        }
        public  List<Film> addFilm(List<Film> FilmList,string title ,string director,int release_year ,string stars,int budget)
        {

            Film addedFilm = new Film(title, director, Convert.ToInt32(release_year), stars, Convert.ToInt32(budget));

            FilmList.Add(addedFilm);
            return FilmList;



        }
        public List<Film> deleteFilmByTitle(List<Film> FilmList, string title)
        {

            foreach (Film element in FilmList)
            {
                if (element.Title ==  title)
                {
                    FilmList.Remove(element);
                    return FilmList;
                }
                
               
            }
            return FilmList;
        }
    }

}
