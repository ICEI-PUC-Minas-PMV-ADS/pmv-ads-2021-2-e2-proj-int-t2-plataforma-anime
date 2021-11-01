using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Animes")]
    public class Anime
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do anime  !")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        public string Descricao { get; set; }

        [Display(Name="Gênero")]
        [Required(ErrorMessage = "Obrigatório informar o gênero!")]
        public int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

        public int Temporadas { get; set; }

        public int Episodios { get; set; }
    }
}