using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_1.Models
{
    public class Librarycontext : DbContext
    {
        public Librarycontext(DbContextOptions<Librarycontext> options) : base(options)
        {
        }
        public DbSet<Books> Book { get; set; }
        public DbSet<Library> Libraries { get; set; }
    }
}