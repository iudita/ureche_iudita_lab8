using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ureche_iudita_lab8.Models;

namespace ureche_iudita_lab8.Data
{
    public class ureche_iudita_lab8Context : DbContext
    {
        public ureche_iudita_lab8Context (DbContextOptions<ureche_iudita_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<ureche_iudita_lab8.Models.Book> Book { get; set; }

        public DbSet<ureche_iudita_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<ureche_iudita_lab8.Models.Category> Category { get; set; }
    }
}
