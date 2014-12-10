using System;

namespace ContadoCaracter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine( " ingrese una palabra");
			string palabra= Console.ReadLine();
			Console.WriteLine(" esta palabra tiene {0} caracteres", palabra.Length);
		}
	}
}
