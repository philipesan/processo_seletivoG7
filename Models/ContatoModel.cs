using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProcessoSeletivoG7.Models
{
    public class ContatoModel
    {
        [Required(ErrorMessage = "O Campo nome é Obrigatório!")]
        [Display(Name = "Nome")]
        public string strNome { get; set; }

        [Required(ErrorMessage = "Valor inválido no campo Função!")]
        [Display(Name = "Função")]
        public string strFuncao { get; set; }

        [Required(ErrorMessage = "O Campo Email é obrigatório!")]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", 
            ErrorMessage = "Email inválido!")]
        [Display(Name = "Email")]
        public string strEmail { get; set; }

        [Required(ErrorMessage = "O Campo Telefone é obrigatório!")]
        [Display(Name = "Telefone")]
        public string strTelefone { get; set; }

    }
}