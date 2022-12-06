using System;
namespace SumaDeDigitos
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();

            int inputInt;

            Console.WriteLine("Ingrese numeros a sumar");
            inputInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma:" + p.digitsSum(inputInt));
        }

        public int digitsSum(int inputInt)
        {
            int Total = 0;
            while (inputInt > 0)
            {
                int mod = inputInt % 10;
                Total = Total + mod;
                inputInt = inputInt / 10;
            }

            return Total;
        }
    }
}