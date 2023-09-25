using System.ComponentModel.DataAnnotations;

namespace filmes_api.Models;

public class Filme
{   
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Titulo { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Genero { get; set; }
    
    [Required]
    [Range(50, 600)]
    public int Duracao { get; set; }
    
}