namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        /*
        var nomeCompleto = "Danilo Rodrigues de Oliveira";

        Func< char, bool > filtro = p => p == 'i';
        // var resultado = nomeCompleto.Where( filtro );

        // var resultado = nomeCompleto.Where( p => p == 'i' );

        var resultado = from c in nomeCompleto where c == 'e' select c;

        foreach ( var letra in resultado )
        {
            Console.WriteLine(letra);
        }
        */

        var numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        var resultado = numeros.Where(p => p % 2 == 1);

        foreach (var valor in resultado)
        {
            Console.Write(valor + " ");
        }

    }

    public void AulaOrdenacao()
    {
        var numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        var nomes = new string[] { "Juliana", "Bruna", "Carina", "Daniely", "Karina", "Vanessa", "Jessica", "Manuelle", "Ana" };

        var resultado = nomes.OrderBy(p => p);

        foreach (var valor in resultado)
        {
            Console.WriteLine(valor + " ");
        }

    }

    public void AulaTake()
    {
        var numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        // var resultado = numeros.Take(5);                                             // pega apenas os 5 primeiros elementos da coleção.
        // var resultado = numeros.Take(5).OrderByDescending(p => p);                   // pega apenas os 5 primeiros elementos da coleção e os ordena de trás para frente.
        var resultado = numeros.Where(p => p > 7).Take(5).OrderByDescending(p => p);    // pega os 5 primeiros elementos da coleção, maior que sete e os ordena de trás para frente.

        Console.WriteLine(" ");

        foreach (var valor in resultado)
        {
            Console.Write(valor + " ");
        }

        Console.WriteLine(" ");
        Console.WriteLine("\nThe End!!!\n");

    }

    public void AulaCount()
    {
        var numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        var resultado0 = numeros.Count();                       // conta quantos elementos há na coleção.
        var resultado1 = numeros.Count(p => p > 10);            // conta quantos elementos há na coleção maiores que 10.
        var resultado2 = numeros.Count(p => p > 10 && p < 20);  // conta quantos elementos há na coleção maiores que 10 e menores que 20.

        Console.WriteLine("\nTotal        : " + resultado0);
        Console.WriteLine("Maior que 10 : " + resultado1);
        Console.WriteLine("Entre 10 e 20: " + resultado2 + "\n");
    }

    public void AulaFirstEFirstOrDefault()
    {
        var numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        var numeros1 = new int[] {};

        var resultado0 = numeros.First();                       // Pega o primeiro elementos da coleção.
        var resultado1 = numeros.First(p => p > 10);            // Pega o primeiro elementos da coleção maior que 10.
        var resultado2 = numeros1.FirstOrDefault();             // Pega o primeiro elemento da coleção, caso não haja elementos, retorna 0 e não uma exception.
        var resultado3 = numeros.FirstOrDefault(p => p > 100);  // Pega o primeiro elemento da coleção maior que 100, caso não haja elementos, retorna 0 e não uma exception.
        var resultado4 = numeros.FirstOrDefault(p => p > 100, -1);  // Pega o primeiro elemento da coleção maior que 100, caso não haja elementos, retorna -1 que foi o valor definido por padrão e não uma exception.

        Console.WriteLine("\nPrimeiro elemento...............................: {0}", resultado0);
        Console.WriteLine("Primeiro elemento maior que 10..................: {0}", resultado1);
        Console.Write("Primeiro elemento First or Default..............: {0}", resultado2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  - Retorna o valor 0 definido por padrão pelo Default e não retorna uma Exception.");
        Console.ResetColor();
        Console.Write("Primeiro elemento First or Default maior que 100: {0}", resultado3);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  - Retorna o valor 0 definido por padrão pelo Default.");
        Console.ResetColor();
        Console.Write("Primeiro elemento First or Default maior que 100: {0}", resultado4);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" - Retorna o valor -1 definido por padrão pelo desenvolvedor.");
        Console.ResetColor();
        Console.WriteLine();
    }
}