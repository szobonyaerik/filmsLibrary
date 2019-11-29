using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class Film
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Stars { get; set; }
        public int Budget { get; set; }

        public Film (string title,string director, int releaseyear, string stars, int budget)
        {
            this.Title = title;
            this.Director = director;
            this.ReleaseYear = releaseyear;
            this.Stars = stars;
            this.Budget = budget;
        }
        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();
            sr.Append($"Title = {this.Title}\nDirector = {this.Director}\nReleaseYear = {this.ReleaseYear}\nStar = {this.Stars}\nBudget = {this.Budget}\n");
            return sr.ToString();

        }
    }
}
