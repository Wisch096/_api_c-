using System.ComponentModel.DataAnnotations;

namespace filmes_api.Dtos;

public class CreateFilmeDto
{
    [Required]
    public string Titulo { get; set; }
    
    [Required]
    [StringLength(50)]
    public string Genero { get; set; }
    
    [Required]
    [Range(50, 600)]
    public int Duracao { get; set; }
}