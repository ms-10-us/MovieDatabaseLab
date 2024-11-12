using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    internal class MovieClass
    {
        public string movieTitle;
        public string movieCategory;

        public MovieClass(string movieTitle, string movieCategory)
        {
            this.movieTitle = movieTitle;
            this.movieCategory = movieCategory;
        }

    }
}
