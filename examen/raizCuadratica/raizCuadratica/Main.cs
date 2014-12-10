using System;

namespace raizCuadratica
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine(" para la ecuacion -3(x*x) + 4x -30 su raiz cuadratica");
			int a= -3;
			int b = 4;
			int c= -30;
			double  resulEcucion1= 0;
			double  resulEcucion2= 0;
			int x= (b*2)-(4*a*c);

			double raizx=Math.Sqrt(x);

			resulEcucion1= (-b+ raizx) /(2*c);
			resulEcucion2= (-b- raizx)  /(2*c);




			Console.WriteLine(" para la ecuacion -3(x*x) + 4x -30 su raiz cuadratica con expresion positiva es : " +resulEcucion1 );
		    Console.WriteLine(" para la ecuacion -3(x*x) + 4x -30 su raiz cuadratica con expresion negativa es : " +resulEcucion2 );
	
		}
	}
}
