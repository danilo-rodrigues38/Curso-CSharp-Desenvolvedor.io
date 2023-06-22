namespace Modulo13;

public class TrabalhandoComArquivos
{
    public void AulaCriandoArquivo()
    {
        var escrever = new StreamWriter("Cadastro.txt", true);
        Console.Write("Informe um nome: ");
        var nome = Console.ReadLine();
        escrever.WriteLine("ID..: " + Random.Shared.Next(1, 100));
        escrever.WriteLine("Nome: " + nome);
        escrever.WriteLine("--------------------------------------------");
        escrever.Close();
    }

    public void AulaLendoArquivo()
    {
        // var conteudo = File.ReadAllText("Cadastro.txt");
        // Console.WriteLine(conteudo);

        var ler = new StreamReader("Cadastro.txt");
        while (!ler.EndOfStream)
        {
            var line = ler.ReadLine();
            Console.WriteLine(line);
        }
        ler.Close();
    }

    public void AulaExcluindoArquivo()
    {
        if (File.Exists("Cadastro.txt"))
        {
            File.Delete("Cadastro.txt");
            Console.WriteLine("Arquivo excluido com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não localizado ou não existe!");
        }
    }
}