using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<WorkExperience> WorkExperiences { get; set; }

        private readonly bool isTestingEnvironment;

        public ApplicationContext(DbContextOptions<ApplicationContext> options, bool isTestingEnvironment = false) : base(options) //Acá estamos llamando al constructor de DbContext que es el que acepta las opciones
        {
            this.isTestingEnvironment = isTestingEnvironment;
        }
    }
}