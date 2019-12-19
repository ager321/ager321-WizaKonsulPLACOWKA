using Microsoft.EntityFrameworkCore;
using WizaKonsulPLACOWKA.Models;

namespace WizaKonsulPLACOWKA.Data
{
    public class MvcSprawaContext:DbContext
    {
        public MvcSprawaContext(DbContextOptions<MvcSprawaContext> options)
            : base(options)
        {
        }

        public DbSet<Sprawa> Sprawa { get; set; }
    }
}
