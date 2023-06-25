using System.Globalization;
using Repository;

namespace AppClientes;

class Program
{
    static ClienteRepository _clienteRepository = new ClienteRepository();
    static void Main(string[] args)
    {
        // Para que o programa aceite as informações de cadastro do tipo Brasil, datas e números.
        var cultura = new CultureInfo("pt-br");
        Thread.CurrentThread.CurrentCulture = cultura;
        Thread.CurrentThread.CurrentUICulture = cultura;

        _clienteRepository.LerDadosCliente();
        while (true)
        {
        Menu();            
        Console.ReadKey();
        }
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine(" Cadastro de Clientes ");
        Console.WriteLine("----------------------");
        Console.WriteLine("1 - Cadaastrar Cliente");
        Console.WriteLine("2 - Exibir Cliente    ");
        Console.WriteLine("3 - Editar Cliente    ");
        Console.WriteLine("4 - Excluir Cliente   ");
        Console.WriteLine("5 - Sair              ");
        Console.WriteLine("----------------------");

        EscolhaOpcao();
    }

    static void EscolhaOpcao()
    {
        Console.Write("Escolha uma opção: ");

        var opcao = Console.ReadLine();

        switch (int.Parse(opcao))
        {
            case 1:
            {
                _clienteRepository.CadastrarCliente();
                Menu();
                break;
            }
            case 2:
            {
                _clienteRepository.ExibirCliente();
                Menu();
                break;
            }
            case 3:
            {
                _clienteRepository.EditarCliente();
                Menu();
                break;
            }
            case 4:
            {
                _clienteRepository.ExcluirCliente();
                Menu();
                break;
            }
            case 5 :
            {
                _clienteRepository.GravarDadosCliente();
                Environment.Exit(0);
                break;
            }
            default:
            {
                Console.Clear();
                Console.WriteLine("Opção Inválida!");
                break;
            }
        }
    }
}
