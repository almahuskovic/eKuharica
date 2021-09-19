using eKuharica.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKuharica
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
        public DbSet<Article> Article { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Follow> Follow { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<RecipeTranslation> RecipeTranslation { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Translation> Translation { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserFavouriteRecipe> UserFavouriteRecipe { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}
