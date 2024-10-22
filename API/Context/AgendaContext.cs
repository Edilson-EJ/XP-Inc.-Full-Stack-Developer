using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Context;

public class AgendaContext : DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
        
    }
    
    public DbSet<Contato> Contatos { get; set; }
    
}