namespace Modulo12;

public class TrabalhandoComExcessoes
{
    public void AulaGerandoExceptions()
    {
        while (true)
        {
            Console.Write("Informe um número: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);

            Console.WriteLine("Resultado: " + resultado);
        }
    }
    public void AulaTratandoExceptions()
    {
        while (true)
        {
            try
            {
                Console.Write("Informe um número: ");
                var numero = Console.ReadLine();
                var resultado = 500 / int.Parse(numero);

                Console.WriteLine("Resultado: " + resultado);
            }
            catch (DivideByZeroException exception)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ocorreu um erro de divisão => " + exception.Message);
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Stack => " + exception.StackTrace);
                Console.ResetColor();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Ocorreu um erro => " + exception.Message);
                Console.WriteLine("Stack => " + exception.StackTrace);
            }
        }
    }
}