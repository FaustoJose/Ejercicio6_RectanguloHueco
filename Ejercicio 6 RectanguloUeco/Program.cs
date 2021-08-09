using System;

namespace Ejercicio_6_RectanguloUeco
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo(11, 20,"f");
        }
        public static void Rectangulo(int altura, int anchura,string letra)
        {
            for (int i = 0; i <= (altura - 1); i++)
            {
                for (int f = 0; f <= (anchura-1 ); f++)
                {
                    if ((i==0)||(i==altura-1)) {
                        Console.Write(letra+letra+letra);
                        Console.Write(" ");
                    }
                    else if ((f == 0) || (f == anchura-1))
                    {
                        Console.Write(letra + letra + letra);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("   ");
                        Console.Write(" ");
                    }
                    
                }

                Console.WriteLine("");
            }
        }
    }
}
