using System;

namespace isNumero
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (" ingrese una oracion:");
			string frase = Console.ReadLine ();
			string [] oracion = frase.Split ();
			string [] num = {"0","2","3","4","5","6","7","8","9"};

			for (int i = 0; i < oracion[i].Length; i++) {
				for( int j= 0; j<num[j].Length; j++){

					if( oracion[i]== num[j]){
								Console.WriteLine("existe un numero");
							}else{
						Console.WriteLine(" no existe un numero");
							}
						}
					}
				}
			
		}
	}

