using filmes_api.Models;
using Microsoft.EntityFrameworkCore;

namespace filmes_api.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
    {
        
    }
    
    public DbSet<Filme> Filmes { get; set; }
}