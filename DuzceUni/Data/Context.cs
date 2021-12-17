using DuzceUni.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUni.Data
{
    public class Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//sql server bağlantı yolınu yazdığımız yer
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9II8GH6;database =DuzceEduTRDatabase; integrated security=true;");

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<SenateBoard> SenateBoards { get; set; }
        public DbSet<DirectorBoard> DirectorBoards { get; set; }
        public DbSet<Cooperation> Cooperations { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<DuzceWelcome> DuzceWelcomes { get; set; }
        public DbSet<GirisPanel> GirisPanels { get; set; }
        public DbSet<Success> Successes { get; set; }
        public DbSet<Publishing> Publishings { get; set; }
    }
}
