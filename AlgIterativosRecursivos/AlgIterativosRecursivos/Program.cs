using System;

namespace AlgIterativosRecursivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el número maximo de la iteración");
            var num = Console.ReadLine();
            Iterativo(Convert.ToInt32(num));
        }

        public static void Iterativo(int a)
        {
            for (int y = 1; y <= a; y++)
            {
                for (int x = 1; x <= a - y; x++)
                {
                    Console.Write(" ");
                }
                for (int x = 1; x <= y; x++)
                {
                    Console.Write(y);
                }
                for (int x = 1; x <= y - 1; x++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
        }

        public static void DrawTree(int max, int color = 0)
        {
            int n = color;
            Console.Write(new string(' ', max - color));
            for (int i = 0; i < n; i++)
                Console.Write(n.ToString() + " ");
            Console.WriteLine();

            if (color == max) return;

            DrawTree(max, n + 1);
        }
    }
}
