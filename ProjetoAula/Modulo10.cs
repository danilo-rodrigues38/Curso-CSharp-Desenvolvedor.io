namespace Modulo10;

public class  TrabalhandoComStrings
{
    public void ConverterParaLetraMinuscula()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
    }

    public void ConverterParaLetraMaiuscula()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }

    public void AulaSubstrings()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(0, 6));       // pega uma cadeia de caracteres a contar da posicao 0 até a posicao 5.
        Console.WriteLine(linha.Substring(6));          // pega todos os caracteres a partir da posicao 6, note que o espaco está na posicao 6.
        Console.WriteLine(linha.Substring(6, 5));       // pega uma cadeia de caracteres a contar da posicao 6, incluindo a posicao 6, e conta os proximos 4 caracteres, note que o espaco está na posicao 6.
    }

    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        string ano = nomeArquivo[..4];
        string mes = nomeArquivo[5..^14];               // no caso expecifico o " ^ ", faz a contagem de tras para a frente, sendo que na terceira posição ele exclui os caracteres
        string dia = nomeArquivo[8..^11];
        string nomeDoArquivo = nomeArquivo[11..^4];
        string nmArqCompleto = nomeArquivo[^10..];
        string extensao = nomeArquivo[^3..];            // no caso expecifico o " ^ ", faz a contagem de tras para a frente, sendo que na primeira posição ele inclui os caracteres

        Console.WriteLine("\nAno: " + ano);
        Console.WriteLine("Mes: " + mes);
        Console.WriteLine("Dia: " + dia);
        Console.WriteLine("Nome do arquivo: " + nomeDoArquivo);
        Console.WriteLine("Extensao: " + extensao);
        Console.WriteLine("Nome do arquivo: {0}\n", nmArqCompleto);

        Console.WriteLine("\nAno: {0}\nMês: {1}\nDia: {2}\nNome do arquivo: {3}\nExtensão: {4}\nNome completo do arquivo: {5}\n", ano, mes, dia, nomeDoArquivo, extensao, nmArqCompleto);
    }
    public void AulaContains()
    {
        string nomeArquivo = "2022_12_01_backup.bak";

        if (nomeArquivo.Contains("backup"))
        {
            Console.WriteLine("\nPalavra encontada!\n");
        }
        else
        {
            Console.WriteLine("\nPalavra não encontada!\n");
        }

        // Console.WriteLine("\nContem nome: {0}\n", nomeArquivo.Contains("backup"));
    }

    public void AulaTrim()
    {
        string teste = "**Danilo Rodrigues**";

        Console.WriteLine("\nTRIM TOTAL: {0}", teste.Trim('*'));
        Console.WriteLine("TRIM INICIO: {0}", teste.TrimStart('*'));
        Console.WriteLine("TRIM FINAL: {0}", teste.TrimEnd('*'));
    }

    public void AulaStartWhithEndWhith()
    {
        string teste = "Curso CSharp";

        Console.WriteLine("\nINICIO: {0}", teste.StartsWith("Curso"));
        Console.WriteLine("FINAL: {0}\n", teste.EndsWith("CSharp02"));
        Console.WriteLine("FINAL: {0}\n", teste.EndsWith("CSharp"));
    }

    public void AulaReplace()
    {
        string teste = "Curso CSharp";

        Console.WriteLine("\n" + teste);
        Console.WriteLine("{0}\n", teste.Replace("CSharp", "C#"));
    }

    public void AulaLength()
    {
        string teste = Console.ReadLine();

        Console.WriteLine("\n" + teste);
        Console.WriteLine("{0}\n", teste.Length);
    }
}