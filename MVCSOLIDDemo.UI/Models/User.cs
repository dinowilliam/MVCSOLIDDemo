using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MVCSOLIDDemo.UI.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Nome do Usuário é nececessário")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Email do Usuário é necessário")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário digitar uma Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "É necessário selecionar o Estado do Usuário")]
        public int Active { get; set; }

        [Required(ErrorMessage = "É necessário informar o Sexo do Usuário")]
        public string Sex { get; set; }

    }
}