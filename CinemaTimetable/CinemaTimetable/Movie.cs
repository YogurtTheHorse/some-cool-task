using System;
using System.Globalization;

namespace CinemaTimetable {
	public class Movie : IEquatable<Movie> {
		public string MovieName { get; }
		public TimeSpan Duration { get; }
		public int Year { get; }

		public MovieRating Rating { get; }

		public RegionInfo[] ProductionCountries { get; }

		public Movie(string name, TimeSpan duration) : this(name, duration, 0) { }

		public Movie(string name, TimeSpan duration, int year) : this(name, duration, year, MovieRating.Unknown, new RegionInfo[] { }) { }

		public Movie(string name, TimeSpan duration, int year, MovieRating rating, RegionInfo[] regions) {
			MovieName = name;
			Duration = duration;
			Year = year;
			Rating = rating;
			ProductionCountries = regions;
		}

		public override string ToString() {
			return $"{MovieName} {Year}";
		}

		public bool Equals(Movie other) {
			return
				other != null &&
				other.MovieName == MovieName &&
				other.Year == Year;
		}

		public override bool Equals(object obj) {
			if (obj is Movie movie) {
				return Equals(movie);
			} else {
				return base.Equals(obj);
			}
		}

        public override int GetHashCode() {
            return unchecked(MovieName.GetHashCode() ^ Year.GetHashCode());
        }
    }
}
