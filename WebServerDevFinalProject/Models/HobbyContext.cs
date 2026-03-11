using Microsoft.EntityFrameworkCore;

namespace WebServerDevFinalProject.Models
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options) : base(options) 
        {
            
        }

        public DbSet<Jon> Jon { get; set; }

        public DbSet<Jaxon> Jaxon { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // This method is used to configure the model and its relationships. 
            // Here we are seeding the database with some initial data for the Jon table.
            modelBuilder.Entity<Jon>().HasData(
                new Jon { JonId = 1, HobbyName = "Hot Wheel Collecting", Category = "Automotive", Description = "I collect sporty Hot Wheel Cars.", Environment = "Indoor", SkillLevel = "Beginner", HobbyAge = 15},
                new Jon { JonId = 2, HobbyName = "Playing First Shooter Games", Category = "Gaming", Description = "I like to play first shooter games like Call of Duty on the weekends", Environment = "Indoor", SkillLevel = "Intermediate", HobbyAge = 5 }
            );

            modelBuilder.Entity<Jaxon>().HasData(
                new Jaxon { JaxonId = 1, HobbyName = "Playing Basketball", Category = "Sports", Description = "I like to play basketball with my friends at the park.", Environment = "Outdoor", SkillLevel = "Beginner", HobbyAge = 10 },
                new Jaxon { JaxonId = 2, HobbyName = "Playing Video Games", Category = "Gaming", Description = "I like to play video games on my PlayStation with my friends.", Environment = "Indoor", SkillLevel = "Expert", HobbyAge = 8 }
            );

        }
    }
}
