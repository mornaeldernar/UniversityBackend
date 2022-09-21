using dermanetBackend.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace dermanetBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {

        }

        // Add DbSets (tablas of our data base)
        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
    }
}
