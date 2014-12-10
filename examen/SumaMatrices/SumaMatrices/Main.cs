using System;

namespace SumaMatrices
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		
			// Declaramos las matrices 
			int[,] A = new int[2,2]; 
			int[,] B = new int[2,2]; 
			int[,] S = new int[2,2]; 
			
			// Llenamos la primer matriz A 
			A[0, 0] = 10; 
			A[0, 1] = 8; 

			
			A[1, 0] = 43; 
			A[1, 1] = 16; 

			// Llenamos la segunda matriz B 
			B[0, 0] = 20; 
			B[0, 1] = 66; 

			
			B[1, 0] = 92; 
			B[1, 1] = 85; 

			
			// Creamos el ciclo que realizara la suma 
			for (int i = 0; i < 2; i++) { 
				for (int j = 0; j < 2; j++) { 
					S[i, j] = A[i, j] + B[i, j]; // Sumamos 
					Console.Write(S[i,j]+" "); // Imprimimos 
				} 
				Console.WriteLine(); // Cambiamos de linea 
			} 
			Console.ReadKey(); 

		}
	}
}
