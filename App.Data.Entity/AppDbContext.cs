using App.Data.Entity.Models;
using System.Data.Entity;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace App.Data.Entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppConnection")
        {
            Database.SetInitializer<AppDbContext>(new CreateDatabaseIfNotExists<AppDbContext>());
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { set; get; }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
