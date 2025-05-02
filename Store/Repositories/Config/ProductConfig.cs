using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { Id = 1,CategoryId=2,ImageUrl="/images/1.png", ProductName = "Computer", Price = 17_000,ShowCase=false },
                new Product() { Id = 2,CategoryId=2,ImageUrl="/images/2.png", ProductName = "Keyboard", Price = 1_000, ShowCase = false },
                new Product() { Id = 3,CategoryId=2,ImageUrl="/images/3.png", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { Id = 4,CategoryId=2,ImageUrl="/images/4.png", ProductName = "Monitor", Price = 7_000 , ShowCase = false },
                new Product() { Id = 5,CategoryId=2,ImageUrl="/images/5.png", ProductName = "Deck", Price = 1_500 , ShowCase = false },
                new Product() { Id = 6,CategoryId=1,ImageUrl="/images/6.png", ProductName = "History", Price = 1_500, ShowCase = false },
                new Product() { Id = 7,CategoryId=1,ImageUrl="/images/7.png", ProductName = "Hamlet", Price = 1_500 , ShowCase = false },
                new Product() { Id = 8, CategoryId = 1, ImageUrl = "/images/1.png", ProductName = "xp-pen", Price = 1_000 , ShowCase = true },
                new Product() { Id = 9, CategoryId = 2, ImageUrl = "/images/2.png", ProductName = "samsung-tel", Price = 1_0300 , ShowCase = true },
                new Product() { Id = 10, CategoryId = 1, ImageUrl = "/images/3.png", ProductName = "ýphone-tel", Price = 1_0000 , ShowCase = true }


            );
        }
    }

}