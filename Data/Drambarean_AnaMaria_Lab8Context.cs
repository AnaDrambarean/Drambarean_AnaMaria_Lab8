using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Drambarean_AnaMaria_Lab8.Models;

namespace Drambarean_AnaMaria_Lab8.Data
{
    public class Drambarean_AnaMaria_Lab8Context : DbContext
    {
        public Drambarean_AnaMaria_Lab8Context (DbContextOptions<Drambarean_AnaMaria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Drambarean_AnaMaria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Drambarean_AnaMaria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Drambarean_AnaMaria_Lab8.Models.Category> Category { get; set; }
    }
}
