using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CyclicRotation
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 3, 8, 9, 7, 6 };

			solution(arr, 3);
		}

		public static int[] solution(int[] A, int K)
		{
			// write your code in C# 6.0 with .NET 4.5 (Mono)
			int[] shifted = ShiftArrayRight(A, K);

			return shifted;
		}

		public static int[] ShiftArrayRight(int[] arrayToShift, int shiftTimes)
		{
			IEnumerable<int> result = arrayToShift.ToList();
			int length = arrayToShift.Length;

			for (int i = 1; i <= shiftTimes; i++)
			{
				IEnumerable<int> firstPart = result.Skip(length - 1);
				IEnumerable<int> secondPart = result.Take(length - 1);

				result = firstPart.Concat(secondPart).ToArray();
			}

			int[] resultArray = result.ToArray();

			return resultArray;
		}
	}
}
