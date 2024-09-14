using Foody_bite.Models;
using Microsoft.EntityFrameworkCore;

namespace Foody_bite.Data
{
    internal class FoodyBiteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-RFGQSC7;Initial Catalog=FoodyBite;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishCategory> DishCategories { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MediaMenu> MediaMenus { get; set; }
        public DbSet<MediaRestaurant> MediaRestaurants { get; set; }
        public DbSet<MediaUser> MediaUsers { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantUser> RestaurantUsers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasKey(c => c.Id);
       
            modelBuilder.Entity<Dish>().HasKey(d => d.Id);
            
            modelBuilder.Entity<Dish>().HasOne(d => d.DishCategory).WithMany(dc => dc.Dishes)
                                       .HasForeignKey(d => d.DishCategoryId);

            modelBuilder.Entity<Dish>().HasOne(d => d.MediaMenu).WithMany(mm => mm.Dishes)
                                       .HasForeignKey(d => d.MediaMenuId);


            modelBuilder.Entity<Dish>().HasOne(d => d.Restaurant).WithMany(r => r.Dishes)
                                       .HasForeignKey(d => d.RestaurantId);
                                    
            modelBuilder.Entity<Ingredient>().HasKey(i => i.Id);
     
            modelBuilder.Entity<DishIngredient>().HasKey(di => new { di.DishId, di.IngredientId });

            modelBuilder.Entity<DishIngredient>().HasOne(di => di.Dish).WithMany(d => d.DishIngredients)
                                                 .HasForeignKey(di => di.DishId);

            modelBuilder.Entity<DishIngredient>().HasOne(di => di.Ingredient).WithMany(i => i.DishIngredients)
                                                 .HasForeignKey(di => di.IngredientId);


            modelBuilder.Entity<Restaurant>().HasKey(r => r.Id);

            modelBuilder.Entity<Restaurant>().HasOne(r => r.Category).WithMany(c => c.Restaurants)
                                             .HasForeignKey(r => r.CategoryId)
                                             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Restaurant>().HasOne(r => r.MediaRestaurant).WithMany(mr => mr.Restaurants)
                                             .HasForeignKey(r => r.MediaRestaurantId)
                                             .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<RestaurantUser>().HasKey(ru => new { ru.RestaurantId, ru.UserId });

            modelBuilder.Entity<RestaurantUser>().HasOne(ru => ru.Restaurant).WithMany(r => r.RestaurantUsers)
                                                 .HasForeignKey(ru => ru.RestaurantId);

            modelBuilder.Entity<RestaurantUser>().HasOne(ru => ru.User).WithMany(u => u.RestaurantUsers)
                                                 .HasForeignKey(ru => ru.UserId);

            modelBuilder.Entity<Review>().HasKey(rw => rw.Id);

            modelBuilder.Entity<Review>().HasOne(rw => rw.User).WithMany(u => u.Reviews)
                                         .HasForeignKey(rw => rw.UserId);

            modelBuilder.Entity<Review>().HasOne(rw => rw.Restaurant).WithMany(u => u.Reviews)
                                         .HasForeignKey(rw => rw.RestaurantId);

            modelBuilder.Entity<User>().HasKey(u => u.Id);

            modelBuilder.Entity<User>().HasOne(u => u.MediaUser).WithMany(muer => muer.Users)
                                       .HasForeignKey(u => u.MediaUserId);

            modelBuilder.Entity<MediaMenu>().HasKey(med => med.Id);
            modelBuilder.Entity<MediaRestaurant>().HasKey(mr => mr.Id);
            modelBuilder.Entity<MediaUser>().HasKey(mu => mu.Id);
            modelBuilder.Entity<DishCategory>().HasKey(dc => dc.Id);


        }


    }
}
