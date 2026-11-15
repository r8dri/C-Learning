// Crea una función que devuelva la cadena "Burp" con la cantidad de letras "r" determinada por los parámetros de entrada de la función.
using System;
public class Program 
{
	public static string LongBurp(int b) 
	{
		char[] arreglo = new char[b];
        for(int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] = 'r';
        }
        string resultado = string.Join("", arreglo);
        return $"Bu{resultado}p";
	}
    static void Main(string[] args)
    {
        System.Console.WriteLine("Cuntas r desea imprimir dentro de la frase:");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(LongBurp(cantidad));
    }
}