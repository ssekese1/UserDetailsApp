using Microsoft.EntityFrameworkCore;
using AgoratechAssessment.Models;

namespace AgoratechAssessment.Data
{
    public class UserContext : DbContext

    {

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
                
        }

        public DbSet<Users> UserDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
                new Users { Id = 1, FirstName = "Carson", Surname = "Alexander" },
                new Users { Id = 2, FirstName = "Meredith", Surname = "Alonso" },
                new Users { Id = 3, FirstName = "Smiley", Surname = "Anand" },
                new Users { Id = 4, FirstName = "Rea", Surname = "Barzdukas" },
                new Users { Id = 5, FirstName = "Liteboho", Surname = "Sekese" },
                new Users { Id = 6, FirstName = "Aupa", Surname = "Potsanyane" },
                new Users { Id = 7,  FirstName = "Carl", Surname = "Jacob" },
                new Users { Id = 8, FirstName = "Omphile", Surname = "Job" },
                new Users { Id = 9, FirstName = "Realeboha", Surname = "Mosebetsi" },
                new Users { Id = 10, FirstName = "David", Surname = "Zuma" }


                );
        }
    }
}
