using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] A = { 9, 3, 9, 3, 9, 7, 9 };

			solution(A);
		}


		public static int solution(int[] A)
		{
			List<int> list = A.ToList();

			var grouped = list.GroupBy(a => a);

			int singleElement = grouped.Where(x => x.Count() == 1).FirstOrDefault().Key;

			return singleElement;
		}
	}
}
