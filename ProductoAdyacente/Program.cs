using System;
namespace ProductoAdyacente
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            //int[] inputArray = new int[] { 3, 6, -2, -5, 7, 3 };
            //int[] inputArray = new int[] { 5, 1, 2, 3, 1, 4 };
            int[] inputArray = new int[] { -23, 4, -3, 8, -12 };
            Console.WriteLine("El producto mayor es:" + p.maxAdjacentProd(inputArray));
        }
        public int maxAdjacentProd(int[] x)
        {
            int Mayor = x[0] * x[1];
            int Producto = 0;
            for (int i = 0; i < x.Length - 1; i++)
            {
                Producto = x[i] * x[i + 1];
                Console.WriteLine(Producto);
                if (Producto > Mayor)
                {
                    Mayor = Producto;
                }
            }
            return Mayor;
        }
    }
}