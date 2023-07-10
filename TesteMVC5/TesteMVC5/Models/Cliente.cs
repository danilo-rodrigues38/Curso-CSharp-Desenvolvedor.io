using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace TesteMVC5.Models
{
    
    public class Cliente
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!!!")]
        public string Name { get; set; }

        [Required ( ErrorMessage = "O campo {0} é obrigatório!!!" )]
        public string Cpf { get; set; }

        [DisplayName ( "E-mail" )]
        [Required ( ErrorMessage = "O campo {0} é obrigatório!!!" )]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido!")]
        public string Email { get; set; }

        [DisplayName ( "Data de nascimento" )]
        [Required ( ErrorMessage = "O campo {0} é obrigatório!!!" )]
        public DateTime Birtday { get; set; }

        [DisplayName ( "Data do cadastro" )]
        [Required ( ErrorMessage = "O campo {0} é obrigatório!!!" )]
        public DateTime Cadastro { get; set; }
    }
}