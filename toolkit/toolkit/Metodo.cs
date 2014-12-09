using System;

namespace toolkit
{
	public class Metodo
	{ 
	    // la variable oracion la puse publica para asi poder trabajarla de ambas clases
		public string [] oracion;
		// este metodo toma el areglo oracion y lo recorre contando los caracteres por palabra en la oracion 
		public  void Contarletras ()
		{

			
			for (  int i = 0; i <  oracion.Length; i++)
			{
				
				// cuando decimos i nos referimos a la posicion de la palabra en el arreglo y despues cuenta sus caracteres
				Console.WriteLine("La cadena en la posicion {0} tiene {1} caracteres", i, oracion[i].Length);

			}

		}
	

		// este metodo toma el array oracion  y la recorre por cada caracter y va preguntando por posicio 
		//si existe una vocal y almacena en el contador un numero
		//Luego imprime el numero de apariciones de las vocales en la oracion

		public void ContarVocales ()
		{
			string[] vocales = {"a","e","i","o","u"};
			int contador =0;
			
			for (int i = 0; i < oracion.Length; i++) {

				for(int j = 0; j <vocales.Length; j++){
				if (oracion[i] == vocales[j]){

						contador ++;
				      


					}
					System.Console.WriteLine(" la cantidad de vocales {0} tiene {1} coinsidencias  ",vocales[j], contador);
				}

			}
		}
		
		// en este metodo se creo un array letras donde contiene todas las consonantes,
		//asi recorrecmes el array oracion y preguntamos donde haya una igual en las posiiones 
		//dentro de ambos arreglos sumamos al contador 1
		public void ContarConsonantes ()
		{
			string [] letras = {"b","c","d","f","g","h","j","k","l","m","n","ñ","p","q","r","s","t","v","w","y","z"};
			int contador = 0;
			for (int i = 0; i < oracion.Length; i++) {
				for (int j =0; j<letras.Length; j++) {
					if (oracion [i] == letras [j]) {
						i=i++;
						contador = contador + 1;

					
					}

				
					System.Console.WriteLine (" la cantidad de consonantes son {0} tinen {1} coinsidencias ", letras [j], contador);
				}
			}
		}
		// al igual que los meodos anteriores creo un array llamado letraMayor donde contiene estas letras en mayuscula asi rrecoro la oracion 
		//y luego recorro el array letrramayuscula luego pregunto si exixte una igualdad por cada posicion pasada si es asi sumamos 1 al contador 
		//y vlvemos a recorrer ambos arreglos hasta terminar el ciclo por cada coincidencia sumamos al contador
		public void ContarMayusculas(){

			string[] letraMayucuscula ={"A","B","C","E","D","F","G","H","I","J","K","L","M","N","Ñ","O","P","Q","R","S","T","U","V","W","Y","Z"};
			int contador = 0;
			for (int i = 0; i < oracion.Length; i++) {
				for (int j =0; j<letraMayucuscula.Length; j++) {
					if (oracion [i] == letraMayucuscula[j]) {
						contador++;
					}
					System.Console.WriteLine (" la cantidad de mayusculas son {0} tinen {1} coinsidencias ",letraMayucuscula [j], contador);
				}
			}

	
		}
// en este metodo utilice el metodo Split en cual separa la oracion en palabras 
		//es decir no toma la oracion correlativa y ademas hice qe me dijera antas palabra tenia la oracion
		public void ContarPalabra(){

			Console.WriteLine(" ingrese una frase cualquiera:");
			string frase = Console.ReadLine();
			string []oracion2 = new string[] {frase};
		    oracion2 = frase.Split(); // split separa la frase en palabras 
			Console.WriteLine("{0} palabras en el texto:", oracion2.Length);

		}

		public void ContarNumeros ()
		{

			//int contador = 0;

		}

		// Al igual q el metodo contarPalaba aqui tambien utilice el metodo Split, pero 
		//con la diferencia del anterior q aqui le asigne un separador, asi al escribir la oracion 
		//y al utiliciar cualquiera de estos separadores ; desde hay cuenta las frases que estan n la oracion
		// ejemplo " el señor, se fue de paseo, al cerro" originalmente split separa as palabras y estan seria 8 palabras distintas, 
		//pero al utilizar separadores podemos decir que existen 3 frases dento de la oracion
		public void ContarOraciones ()
		{

			
			Console.WriteLine(" ingrese una oracion:");
			string frase = Console.ReadLine();
			string []oracion5 = new string[] {frase};
			char []separador ={',','?','!','.',';',':','\n','\r'};
			oracion5 = frase.Split(separador); // split separa la frase en palabras 
			Console.WriteLine("{0} oraciones distintas  en esta oracion:", oracion5.Length);

		}
	    // este metodo busca la palabra mas larga dentro de la cadena
		public void PalabraMayor ()
		{
			// asignamos la palabra mas larga dentro de esta variable 
			string palabra = "";
			//recorremos la cadena que en este caso es oracion
			for (int pos=0; pos < oracion.Length; pos++) {
				// luego preguntamos si la palabra en mayor a alguna palabra dento de la cadena 
				//recordemos de la oracion ya viene aplicada el metodo Split asi que viene con palabras separadas
				if(palabra.Length < oracion[pos].Length){
						palabra=oracion[pos];
					}
				}
				Console.WriteLine(" la palabra mas larga es:"+ palabra);
			}




            public void LetraMasRepetida ()
		{
			/*
			int [] conteo;
			string[] letras;
							
				for (int i = 0; oracion.Length; i ++) {
					int pos = buscar(letras, oracion[i]);
					if( pos >=0){
						conteo[pos]++;
						
					} else {
						letras[letras.Length -1] = oracion[i];
						conteo[conteo.Length -1] = oracion[i];
					}
					
				}
			Console.WriteLine(" la letra mas repetida es :");
			//int index =0
				//for ( i=0; i< conteo.length ; i ++
				//if ( conteo[index] < conteo[i])
				 //index = i;
			    //retunr index;
				
				
			}
			
			int buscar (string[] arreglo, string letra)
			{
				if (arreglo == null || arreglo.Length == 0) {
					
					return -1;
					
				}
				int i = 0;
				do {
					
					if(arreglo[i] == letra){
						return i;
					}else{
						i ++;
					}
					
				}while ( i <arreglo.Length);
				return -1;
				
			}
			*/
		}
		// Para saber si una caracter está contenido en una cadena usamos el método Contains
		//la sintaxis es nombredelacadena.Contains(‘caracter’), el valor devuelto será un valor
		//booleano (cierto o falso).
		public void buscarLetra(){

			Console.WriteLine(" ingrese una palabra:");
			string palabra = Console.ReadLine();
			Console.WriteLine(" ingrese una letra para buscar:");
			string letra=Console.ReadLine();
			Console.WriteLine(" ahora vamos a ver si la letra {0} esta en la palabra es: {1}",letra,  palabra.Contains(letra));
		}
		// metodo que inserta una letra q nosotros queramos y en la posicion que queramos
		public void inserta(){
			// ingresamos la palabra para manipular
			Console.WriteLine(" ingrese una palabra:");
			string frase = Console.ReadLine();
			string []palabra= new string[] {frase};
			// ingresamos la letra que queramos
			Console.WriteLine(" ingrese una letra que quiera agregar");
			string letra= Console.ReadLine();
			// elijimos la posicion que queremos que tenga
			Console.WriteLine("ingrese la posicion donde quiere que este la letra");
			string valor= Console.ReadLine();
			int pos= int.Parse(valor);
			// comprobamos que la posicion asignada sea mayor a cero y este dentro del rango de la palabra
			if(pos>=0 && pos< palabra.Length){
				//luego recorremos el arreglo y decimos palabra.length-1 sea igual a i y i mayor pos y a eso le restamos -1
				for(int i = palabra.Length-1; i>pos; i--)
					palabra[i]=palabra[i-1];
				palabra[pos] = letra;
				Console.WriteLine("la nueva frase es:" + palabra);
			}
			else throw new Exception("Posición no válida");
		}
		public void InviertePalabra ()
		{
			// ingresamos la palabra para manipular
			Console.WriteLine (" ingrese una palabra:");
			string palabra = Console.ReadLine ();
			string palabraInvertida = "";
			int cantidad = palabra.Length;
			//Recorremos el string en orden inverso
			for (int i= cantidad -1; i>0; i--) {
				// asignamos la palabra inversita a nuetra nueva variable string
				palabraInvertida= palabraInvertida+ palabra.Substring(i,1);
			}
			Console.WriteLine("la palabra invertida es {0}:",palabraInvertida);
		}

// metodo palidromo este recorre una cadena de palbras y verifica si es palindromo o no
		public  bool polindromo(string[] oracion)
		{
			string[] subcadena=oracion;
			int num = subcadena.Length;
			int i= num / 2;
			int indicador=0;

			for (int j = 0; j < i; j++)
			{
				// verificamos que la subcadena ya recorrida en j, es igual a subcadena 
				// donde num es la cantidad de caracteres de la subcadena - j y menos 1
				// si es asi sumamos uno al contador indicador
				if (subcadena[j] == subcadena[num - j - 1])
					indicador++;
			}
			// si indicador es igual a 1 es palindrmo si no es false 
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
		




		
				
	

	
	
	
	
	