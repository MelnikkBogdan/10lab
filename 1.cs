using System;
class Program
{
    static void Main()
    {

        Random rnd_num = new Random();
        int N;

        Console.WriteLine("enter N:");
        N = int.Parse(Console.ReadLine());
        double[] mass = new double[N];
        double[] mas = new double[N];
        int i = 0;
        for (int j = 0; j < N; j++)
        {
            mass[j] = rnd_num.Next(-5, 15);
            Console.Write($"{mass[j].ToString()}  \t");
            if (mass[j] > 3 && i <= 4)
            {
                mas[i] = mass[j];
                i++;
            }

        }
        Console.Write("\n");
        for (i = 0; i < 4; i++)
        {
            Console.Write($"{mas[i].ToString()}  \t");
        }


        double a = mas[1], b = mas[3], c = a + b;
        Console.Write($"\n" + c);
    }
}