using System;

namespace multiplica
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("ingrese un numero para ver su tabla de multiplicar");
			string valor = Console.ReadLine();
			int numero = int.Parse(valor);

			int resultado= 0;
			for (int i = 1; i <= 10; i++ )
			{
				resultado = numero * i;
				Console.WriteLine(numero+ " * " +i+ " = " +resultado);
			}
		}
	}
}
