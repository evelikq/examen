using System;

namespace ejercico7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int []a = {1, 3, 5, 6, 2, 9, 7, 4};
			int i,j;
			int iMin;
			int n;
			for (j = 0; j < n ­-1; j++) { 
				iMin = j;
				for ( i = j+1; i < n; i++) {
					if (a[i] < a[iMin]) {
						iMin = i;
					}
				} 
				if(iMin != j) {
					swap(a[j], a[iMin]);
				} 
			}
			Console.WriteLine(a);
		}
	}
}
