using Microsoft.EntityFrameworkCore;

namespace WebServerDevFinalProject.Models
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options) : base(options) 
        {
            
        }

        public DbSet<Jon> Jon { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // This method is used to configure the model and its relationships. 
            // Here we are seeding the database with some initial data for the Jon table.
            modelBuilder.Entity<Jon>().HasData(
                new Jon { JonId = 1, HobbyName = "Hot Wheel Collecting", Category = "Automotive", Description = "I collect sporty Hot Wheel Cars.", Environment = "Indoor", SkillLevel = "Beginner", HobbyAge = 15},
                new Jon { JonId = 2, HobbyName = "Playing First Shooter Games", Category = "Gaming", Description = "I like to play first shooter games like Call of Duty on the weekends", Environment = "Indoor", SkillLevel = "Intermediate", HobbyAge = 5 }
            );


        }
    }
}
