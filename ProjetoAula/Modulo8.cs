// namespace Cadastro;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }

    public class Produto
    {
        private int id;

        public string Descricao { get; set; }

        //public readonly int Estoque;
        public int Estoque { get; }

        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + Descricao);
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }
    }


    public class Pessoa
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Código: " + Id);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("Cep: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + Cpf);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string Matricula { get; set; }

        public void ImprimirMatricula()
        {
            Console.WriteLine("Matrícula: " + Matricula);
        }
    }

    public sealed class Configuracao
    {
        public string Host { get; set; }
    }

    public abstract class Animal
    {
        public string Nome { get; set; }

        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome animal: " + Nome);
            Console.WriteLine("Informações: " + GetInformacoes());
        }
    }

    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo!";
        }
    }

    public record Curso (int Id, string Descricao);

    public class CursoTeste
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }

    /*
    public record Curso
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj is Curso curso)
            {
                return Id == curso.Id && Descricao == curso.Descricao;
            }


            return base.Equals(obj);
        }

        public static bool operator ==(Curso a, Curso b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Curso a, Curso b)
        {
            return a.Equals(b);
        }
    }*/

    public interface INotificacao
    {
        string Descricao { get; set; }
        void Notificar();
    }

    public class NotificacaoCliente : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando Cliente!");
        }

        public void NotificarOutros()
        {
            Console.WriteLine("Notificando Outros!");
        }
    }

    public class NotificacaoFuncionario : INotificacao
    {
        public string Descricao { get; set; }

        public void Notificar()
        {
            Console.WriteLine("Notificando Funcionario!");
        }

        public void NotificarOutros()
        {
            Console.WriteLine("Notificando Outros!");
        }
    }

}

