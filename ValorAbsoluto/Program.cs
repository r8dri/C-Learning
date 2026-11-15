// Toma un arreglo de enteros (positivos, negativos o ambos) y devuelve la suma del valor absoluto de cada elemento.
using System;
class Program
{
    public static int GetAbsSum(int[] numeros)
    {
        int suma = 0;
        for(int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] < 0)
            {
                numeros[i] = numeros[i] * (-1);
            }
            suma += numeros[i];
        }
        return suma;
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Cuantos numeros ingresaras:");
        int tamaño = Convert.ToInt32(Console.ReadLine());
        int[] arreglo = new int[tamaño];
        System.Console.WriteLine("Ingresa los numeros acontinuacion:");
        for(int i = 0; i < arreglo.Length; i++)
        {
            System.Console.WriteLine($"Numero [{i + 1}]:");
            arreglo[i] = Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine($"La suma absoluta de los numeros ingresados es: {GetAbsSum(arreglo)}");
    }
}