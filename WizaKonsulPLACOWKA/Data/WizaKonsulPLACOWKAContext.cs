using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WizaKonsulPLACOWKA.Models;

namespace WizaKonsulPLACOWKA.Data
{
    public class WizaKonsulPLACOWKAContext : DbContext
    {
        public WizaKonsulPLACOWKAContext (DbContextOptions<WizaKonsulPLACOWKAContext> options)
            : base(options)
        {
        }

        public DbSet<WizaKonsulPLACOWKA.Models.Sprawa> Sprawa { get; set; }
    }
}
