using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; // définir la valeur de n
        int sum = 0; // initialiser la somme à zéro

        for (int i = 1; i <= n; i++)
        {
            Console.ReadLine("bonjour");
            sum += i; // ajouter chaque nombre à la somme
        }

        Console.WriteLine("La somme des nombres de 1 à {0} est : {1}", n, sum);
        Console.ReadLine();
    }
}
