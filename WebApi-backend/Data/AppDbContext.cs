using Microsoft.EntityFrameworkCore;
using WebApi_backend.Model;
using System.Data;

namespace WebApi_backend.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<EmplyeeDetails> EmpDetails { get; set; }
    }
}
