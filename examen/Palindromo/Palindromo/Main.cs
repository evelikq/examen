using System;

namespace Palindromo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("--- hay palindrmo ??");
			Console.WriteLine(" ingrese una oracion:");
			string frase = Console.ReadLine();
			string []oracion= frase.Split();
			MainClass m = new MainClass();
			m.polindromo(oracion);
			if(m.polindromo(oracion))
			{
				Console.WriteLine(" :>>>>   Es Polindromo");  
			}
			else
			{
				Console.WriteLine(" :>>>>   No es Polindromo"); 
			}
	   	}
	
		public  bool polindromo(string[] oracion)
		{
			string[] subcadena=oracion;
			int num = subcadena.Length;
			int i= num / 2;
			int indicador=0;
			
			for (int j = 0; j < i; j++)
			{

				if (subcadena[j] == subcadena[num - j - 1])
					indicador++;
			}

			if (indicador == i)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	
	}
}
