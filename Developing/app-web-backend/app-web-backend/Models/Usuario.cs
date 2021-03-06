using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key] 
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o e-mail!")]
        public string Email { get; set; }
        public int Status { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de nascimento!")]
        public string Data_nasc { get; set; }
    }
}
