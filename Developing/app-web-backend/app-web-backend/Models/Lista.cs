using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Listas")]
    public class Lista
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Usuários")]
        [Required(ErrorMessage = "Obrigatório informar o Usuário!")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o anime!")]
        public int AnimeId { get; set; }
        [ForeignKey("AnimeId")]
        public Anime Anime { get; set; }

        public int Avaliacao { get; set; }

    }
}