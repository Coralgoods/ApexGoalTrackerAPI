using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; 

namespace ApexGoalTrackerAPI.DataObjects

{

    public class ApexContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CurrentStats> currentStats { get; set; }
        public DbSet<UserGoal> userGoals { get; set; }
        
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ApexTracker;Trusted_Connection=True;");
        }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var builder = new ConfigurationBuilder();
        //    builder.AddJsonFile("appsettings.json", optional: false);
        //    var configuration = builder.Build();
        //    string connectionString = configuration.GetConnectionString("DefautConnection");
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

    }
}
