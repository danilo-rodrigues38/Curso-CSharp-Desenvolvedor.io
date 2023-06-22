// Console.WriteLine("Hello, World!");

using System;
using Cadastro;
using Conversores;
using Modulo10;
using Modulo11;
using Modulo12;
using Modulo13;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // AulaClasses();
            // AulaPropriedadeSomenteLeitura();
            // AulaHeranca();
            // AulaClasseSelada();
            // AulaClasseAbstrata();
            // AulaRecord();
            // AulaInterface();
            // Conversores();
            // TrabalhandoComStrings();
            // TrabalhandoComDatas();
            // TrabalhandoComExcessoes();
            TrabalhandoComArquivos();
        }

        public static void TrabalhandoComArquivos()
        {
            var trabalhandoComArquivo = new TrabalhandoComArquivos();
            // trabalhandoComArquivo.AulaCriandoArquivo();
            // trabalhandoComArquivo.AulaLendoArquivo();
            trabalhandoComArquivo.AulaExcluindoArquivo();
        }

        public static void TrabalhandoComExcessoes()
        {
            var trabalhandoComExcessoes = new TrabalhandoComExcessoes();
            // trabalhandoComExcessoes.AulaGerandoExceptions();
            trabalhandoComExcessoes.AulaTratandoExceptions();
        }

        public static void TrabalhandoComDatas()
        {
            var trabalhandoComDatas = new TrabalhandoComDatas();
            // trabalhandoComDatas.AulaDateTime();
            // trabalhandoComDatas.AulaSubtraindoDatas();
            // trabalhandoComDatas.AulaAdicionandoDiasMesAno();
            // trabalhandoComDatas.AulaAdicionandoHoraMinutoSegundos();
            // trabalhandoComDatas.AulaRecuperarDiaDaSemana();
            // trabalhandoComDatas.AulaDateOnly();
            trabalhandoComDatas.AulaTimeOnly();
        }

        public static void TrabalhandoComStrings()
        {
            var trabalhandoComStrings = new TrabalhandoComStrings();
            // trabalhandoComStrings.ConverterParaLetraMinuscula();
            // trabalhandoComStrings.ConverterParaLetraMaiuscula();
            // trabalhandoComStrings.AulaSubstrings();
            // trabalhandoComStrings.AulaRange();
            // trabalhandoComStrings.AulaContains();
            // trabalhandoComStrings.AulaTrim();
            // trabalhandoComStrings.AulaStartWhithEndWhith();
            // trabalhandoComStrings.AulaReplace();
            trabalhandoComStrings.AulaLength();
        }

        private static void Conversores()
        {
            var conversores = new Conversor();
            // conversores.ConvertAndParse();
            conversores.aulaTryParse();
        }

        public static void AulaInterface()
        {
            var notificacaoCliente = new NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            INotificacao notificacaoFuncionario= new NotificacaoFuncionario();
            notificacaoFuncionario.Notificar();
            // notificacaoFuncionario.NotificarOutros();    // não é possivel acessar a classe poe na instanciação foi direcionado para 
                                                            // "INotificacao" e lá não há o método NotificarOutros, somente dentro da classe NotificarFuncionario.
        }

        public static void AulaRecord()
        {
            // var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
            // var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };

            var curso1 = new Cadastro.Curso (1, "Curso");
            var curso2 = curso1 with { Descricao = "Teste Novo" };

            // var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
            // var curso2 = curso1;
            // curso2.Descricao = "TESTE TESTE";
            // var curso2 = new Cadastro.CursoTeste();

            // curso2.Id = curso1.Id;
            // curso2.Descricao = "Nova Descricao";

            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);


            // Console.WriteLine(curso1 == curso2);
            // Console.WriteLine(curso1.Equals(curso2));
        }

        public static void AulaClasseAbstrata()
        {
            var cachorro = new Cachorro();
            cachorro.Nome = "Belinha";
            cachorro.ImprimirDados();
        }

        public static void AulaClasseSelada()
        {
            // var configuracao = new Cadastro.Configuracao();
            // configuracao.host = "localhost";

            var configuracao = new Configuracao { Host = "localhost" };

            Console.WriteLine(configuracao.Host);
        }

        private static void AulaHeranca()
        {
            // var pessoaFisica = new Cadastro.PessoaFisica();
            // pessoaFisica.id = 1;
            // pessoaFisica.endereco = "Endereço Teste";
            // pessoaFisica.cidade = "Cidade Teste";
            // pessoaFisica.cep = "01234-567";
            // pessoaFisica.cpf = "123.456.789.10";
            // pessoaFisica.ImprimirDados();
            // pessoaFisica.ImprimirCpf();

            var funcionario = new Cadastro.Funcionario();
            funcionario.Id = 10;
            funcionario.Endereco = "Endereço Teste";
            funcionario.Cidade = "Cidade Teste";
            funcionario.Cep = "01234-567";
            funcionario.Cpf = "123.456.789.10";
            funcionario.Matricula = "987654321";
            funcionario.ImprimirDados();
            funcionario.ImprimirCpf();
            funcionario.ImprimirMatricula();
        }

        public static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
            Console.WriteLine(resultado);
            /*
            var produto = new Cadastro.Produto();
            produto.SetId(1);
            produto.Descricao = "Teclado RGB Philips";

            produto.ImprimirDescricao();
            Console.WriteLine(produto.GetId());
            */
        }

        public static void AulaPropriedadeSomenteLeitura()
        {
            var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse sem fio";
            //produto.Estoque = 1; // não é possível adicionar um valor por ser um atributo somente leitura, somente pelo construtor é possível atribuir um valor.
            Console.WriteLine(produto.Estoque + " - " + produto.Descricao);
        }
    }
}

/*
namespace Cadastro
{
    public class Cliente
    {
    }

    public class Funcionario
    {
    }
}


namespace Financeiro
{
    public class ContasReceber
    {
    }

    public class Funcionario
    {
    }
}
*/