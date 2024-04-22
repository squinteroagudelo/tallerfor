namespace divisores;

internal class Program
{
	// Escriba un programa que le solicite un número entero positivo al usuario e imprima en pantalla los divisores.

	public static void Main(string[] args)
	{
		int num;
		Console.Write("Ingrese un número entero y positivo: ");
		num = Convert.ToInt32(Console.ReadLine());

		if (num > 0)
		{
			Console.WriteLine("Los divisores de " + num + " son:");
			for (int i = 1; i <= num; i++)
			{
				if (num % i == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
		else
		{
			Console.Write("El número ingresado no es válido.");
		}

		Console.ReadLine();
	}
}