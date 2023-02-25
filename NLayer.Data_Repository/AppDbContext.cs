using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Data_Repository.Confugirations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Data_Repository
{
    public class AppDbContext:DbContext
    {
        //DbContextOptions ona gore yaziriq ki bunun VB de olan yolunu staratupda(net5) / program.cs(net6) yazacagiq
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfugration());
            modelBuilder.ApplyConfiguration(new ProductConfugration());
            modelBuilder.ApplyConfiguration(new ProductFeatureConfugration());

            //Verilen elave etmeyin 2-ci yolu. Lakin best practise baximindan meslehet gorulmur burda etmek
            modelBuilder.Entity<ProductFeature>().HasData(
            new ProductFeature()
            {
                Id=1,
                ProductId=1,
                Width=1,
                Height=1,
                Color="#ededed"
            },

            new ProductFeature()
            {
                Id = 2,
                ProductId = 2,
                Width = 2,
                Height = 3,
                Color = "#000"
            }
            );
        }
    }
}
