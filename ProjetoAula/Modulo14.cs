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
        var resultado = numeros.Where( p => p % 2 == 1);

        foreach (var valor in resultado)
        {
            Console.Write(valor + " ");
        }

    }

    public void AulaOrdenacao()
    {
        var numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
        var nomes = new string[] { "Juliana", "Bruna", "Carina", "Daniely",  "Karina", "Vanessa", "Jessica", "Manuelle", "Ana" };
        
        var resultado = nomes.OrderBy( p => p);

        foreach (var valor in resultado)
        {
            Console.WriteLine(valor + " ");
        }

    }
}