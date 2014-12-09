using System;

namespace toolkit
{
	class MainClass
	{ 

		public static void Main (string[] args)
		{

			Metodo m = new Metodo();
			Console.WriteLine ("trabajo 3 evelik quezada");
			Console.WriteLine(" ingrese una oracion:");
		    string frase = Console.ReadLine();
			m.oracion= frase.Split();

			m.Contarletras();
			Console.WriteLine("--------------------");
			m.ContarVocales();
			Console.WriteLine("--------------------");
			m.ContarConsonantes();
			Console.WriteLine("--------------------");
			m.ContarMayusculas();
			Console.WriteLine("--------------------");
			m.ContarPalabra();
			Console.WriteLine("--------------------");
			m.ContarOraciones();
			Console.WriteLine("--------------------");
			m.PalabraMayor();
			Console.WriteLine("--------------------");
			m.buscarLetra();
			Console.WriteLine("--------------------");
			m.inserta();
			Console.WriteLine("--------------------");
			m.InviertePalabra();


			Console.WriteLine("--------------------");
			Console.WriteLine("----Palindromo-----");
			if(m.polindromo(m.oracion))
			{
				Console.WriteLine(" :>>>>   Es Polindromo");  
			}
			else
			{
				Console.WriteLine(" :>>>>   No es Polindromo"); 
			}
		
		}

	}
}
