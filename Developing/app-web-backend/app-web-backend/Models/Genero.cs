using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Generos")]
    public class Genero
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Genero!")]
        public string Nome { get; set; }
     
        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        public string Descricao { get; set; }

        public ICollection<Anime> Animes { get; set; }
    }
}