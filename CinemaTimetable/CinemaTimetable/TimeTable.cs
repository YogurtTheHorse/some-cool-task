using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTimetable {
	public class TimeTable : ICollection<MovieShow> {
		private List<MovieShow> _shows;

		public int Count => _shows.Count;
		public bool IsReadOnly => false;

		public TimeTable() {
			_shows = new List<MovieShow>();
		}

		public void Add(MovieShow show) => _shows.Add;

		public void Clear() => _shows.Clear;

		public bool Contains(MovieShow show) => _shows.Contains;

		public void CopyTo(MovieShow[] array, int arrayIndex) => _shows.CopyTo;

		public IEnumerator<MovieShow> GetEnumerator() => _shows.GetEnumerator;

		public IEnumerable<MovieShow> GetShowsByDay(DayOfWeek dayOfWeek) => _shows.Where(ms => ms.DayOfWeek == dayOfWeek);

		public bool Remove(MovieShow item) => _shows.Remove;

		public IEnumerator IEnumerable.GetEnumerator() => _shows.GetEnumerator;
	}
}
