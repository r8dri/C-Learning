class Program
{
    public static double[] FindMinMax(double[] values)
    {
        double[] arreglo = new double[values.Length];
        double[] minMax = new double[2];
        double mayor = values[0];
        double menor = values[0];
        for(int i = 1; i < arreglo.Length; i++)
        {
            arreglo[i] = values[i];
            if(values[i] >= mayor)
            {
                mayor = values[i];
            } else if(values[i] <= menor)
            {
                menor = values[i];
            }
            
        }
        minMax = [menor, mayor];


        return minMax;
    }
    static void Main(string[] args)
    {
      var mostrar = FindMinMax([1, 3, 2]);
      for(int i = 0; i < mostrar.Length; i++)
        {
            System.Console.Write($"{mostrar[i]} ");
        }
    }
}
