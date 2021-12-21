using avds.Models;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {

    }
    public DbSet<Pessoa> Pessoa { get; set;}
    public DbSet<Contatos> Contatos { get; set;}
    

}