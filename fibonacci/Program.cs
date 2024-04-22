namespace fibonacci;

internal class Program
{
	// Escriba un programa que imprima en pantalla la serie de números de Fibonacci menores de 100.
	
	public static void Main(string[] args)
	{
		long a = 0, b = 1;

		Console.Write("Ingrese la cantidad de números de la secuencia de Fibonacci que desea imprimir: ");
		long cantidad = long.Parse(Console.ReadLine());

		Console.Write(a + " " + b + " ");

		for (long i = 3; i <= cantidad; i++)
		{
			long c = a + b;

			if (c < 0)
			{
				break;
			}

			/*La siguiente sentencia limita la sucesión a números menores que 100.
			Si desea imprimir la cantidad de números ingresada, por favor, coméntela.
			NOTA: La cantidad máxima que imprime es 93 números*/
			if (c >= 100) break;

			Console.Write(c + " ");
			a = b;
			b = c;
		}

		Console.ReadLine();
	}
}