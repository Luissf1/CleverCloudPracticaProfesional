using System;
namespace Palindromos
{
    class Program
    {

        static void Main()
        {
            Program p = new Program();

            string inputStr = " ";
            Console.WriteLine("Ingrese un texto:");
            inputStr = Console.ReadLine();
            p.isPalindrome(inputStr);
            Console.WriteLine(p.isPalindrome(inputStr));
        }

        public bool isPalindrome(string Palabra)
        {
            string PalabraInversa = "";
            int size = Palabra.Length;
            while (size > 0)
            {
                PalabraInversa = PalabraInversa + Palabra[size - 1];

                size--;

            }

            if (Palabra == PalabraInversa)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}