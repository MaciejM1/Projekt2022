using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekt2022.Models;

namespace Projekt2022.Data
{
    public class Projekt2022Context : DbContext
    {
        public Projekt2022Context (DbContextOptions<Projekt2022Context> options)
            : base(options)
        {
        }

        public DbSet<Projekt2022.Models.User> User { get; set; } = default!;
    }
}
