using Microsoft.EntityFrameworkCore;

namespace Ejemplo_de_MVC2.Models
{
    public class usuariosContext : DbContext
    {

            public usuariosContext(DbContextOptions<usuariosContext> options) : base(options)
            {

            }

            public DbSet<usuarios> usuarios { get; set; }
        
    }
}
