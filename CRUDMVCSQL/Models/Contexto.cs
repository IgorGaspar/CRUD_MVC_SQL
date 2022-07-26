using Microsoft.EntityFrameworkCore;

namespace CRUDMVCSQL.Models
{
    public class Contexto : DbContext
    {
        /// <summary>
        /// Classe criada para referenciar com o Entity Framework.
        /// </summary>
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
    }
}
