namespace Conversores;

public class Conversor
{
    public void ConvertAndParse()
    {
        // int numero = int.Parse("1");
        // int numero = Convert.ToInt32 (null);
        // int numero = int.Parse(null);
        bool verdadeiro = bool.Parse("true");

        // Console.WriteLine( numero );
        Console.WriteLine( verdadeiro );
    }

    public void aulaTryParse()
    {
        // var numero = "123456";
        var numero = "abc";

        if ( int.TryParse( numero, out int numeroConvertido ) )
        {
            Console.WriteLine( "Numero foi convertido com sucesso!" );
        }

        Console.WriteLine(numeroConvertido);
    }
}