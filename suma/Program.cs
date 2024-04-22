namespace suma;

internal class Program
{
	// Hacer un algoritmo que calcule la suma de los cien primeros números.
	public static void Main(string[] args)
	{
		int suma = 0;

		for (int i = 1; i <= 100;  i++) 
		{
			suma += i;
    
		}
		Console.WriteLine("La suma de los 100 primeros números es: " + suma);

		Console.ReadLine();
	}
}