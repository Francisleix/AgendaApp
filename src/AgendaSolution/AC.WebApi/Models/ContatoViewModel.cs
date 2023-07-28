using AC.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AC.WebApi.Models
{
    public class ContatoViewModel
    {
        public int ID { get; set; }


        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome")]

        public string Nome { get; set; }



        [Required(ErrorMessage = "O email do usuário é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Email")]

        public string Email { get; set; }



        [Required(ErrorMessage = "O telefone do usuário é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Telefone")]

        public string Telefone { get; set; }

        public bool Status { get; set; }

        public class ContatoViewModelCollection : List<Contato>
        {

        }
    }
}