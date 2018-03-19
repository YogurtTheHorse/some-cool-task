using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimetable {
    public class MovieShow: IEquatable<MovieShow> {
        public Movie Movie { get; set; }
        int Hall { get; set; }

        DateTime Date;
        DayOfWeek DayOfWeek { get => Date.DayOfWeek; }
         

        public MovieShow(Movie movie, DateTime date, int hall) {
            Movie = movie;
            Date = date;
            Hall = hall;
        }

        public bool Equals(MovieShow second) {
            if (second == null) {
                return false;
            }

            return (Movie == second.Movie) && (Date == second.Date) && (Hall == second.Hall);
        }
    }
}
