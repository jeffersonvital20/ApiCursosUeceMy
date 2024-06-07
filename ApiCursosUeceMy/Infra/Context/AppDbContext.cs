using ApiCursosUeceMy.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiCursosUeceMy.Infra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}

    public DbSet<Curso> Curso { get; set; }
    public DbSet<Aula> Aula { get; set; }
}