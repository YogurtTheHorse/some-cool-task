using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimetable {
    public class MovieShow: IEquatable<MovieShow> {
        public Movie Movie { get; set; }
        public int Hall { get; set; }

        public TimeSpan TimeOfDay { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
         

        public MovieShow(Movie movie, TimeSpan timeOfDay, DayOfWeek dayOfWeek, int hall) {
            Movie = movie;
            TimeOfDay = timeOfDay;
            DayOfWeek = dayOfWeek;
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
