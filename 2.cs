using System;
internal class Program
{
    static void diagonal(double[,] mass, int n)
    {
        double c1 = 0, c2 = 0;
        for (int i = mass.GetLength(0) - 1; i >= 0; --i)
            for (int j = mass.GetLength(1) - 1; j >= 0; --j)
            {
                if (i == j) { c1 = c1 + mass[i, j]; }
                if (i + j + 1 == n) { c2 = c2 + mass[i, j]; }
            }


        Console.Write($"\nГоловна:" + c1 + "\nПобічна:\n" + c2);

    }
    static void minus(double[,] mass)
    {
        int c = 0;
        for (int i = mass.GetLength(0) - 1; i >= 0; --i)
            for (int j = mass.GetLength(1) - 1; j >= 0; --j)
            {
                if (mass[i, j] < 0) { c++; }
            }


        Console.Write(c);

    }
    static void Main(string[] args)
    {
        Random rnd_num = new Random();
        int N;
        N = int.Parse(Console.ReadLine());
        double[,] masiv = new double[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                masiv[i, j] = rnd_num.Next(-10, 10);
                Console.Write($"{masiv[i, j]} \t");
            }
            Console.Write("\n");
        }
        Console.Write($"Кількість відємних:\n");
        minus(masiv);
        diagonal(masiv, N);
    }
}