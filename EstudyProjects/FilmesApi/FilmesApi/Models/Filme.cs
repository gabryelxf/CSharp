using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int IdFilme { get; set; }
        
        [Required ( ErrorMessage = "O título do filme é obrigatório")]
        [MaxLength (100, ErrorMessage = "O título nao pode exceder 100 caracteres")]
        public string Titulo { get; set; }

        [Required (ErrorMessage = "O gênero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O gênero do filme não pode exceder 50 caracteres")]
        public string Genero { get; set; }

        [Required (ErrorMessage = "A duração do filme é obrigatória")]
        [Range(70, 600, ErrorMessage = ("A duração deve estar entre 70 e 600 minutos"))]
        public int Duracao { get; set; }
    }
}
