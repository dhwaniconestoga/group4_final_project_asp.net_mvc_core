using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group4_FinalProject.Models
{
    internal class SeedProducts : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasData(
                new Product { ProductId = 1, Title = "1776", Description = "1776", CategoryId = "history", Price = 18.00 },
                new Product { ProductId = 2, Title = "1984", Description = "1776", CategoryId = "scifi", Price = 5.50 },
                new Product { ProductId = 3, Title = "And Then There Were None", Description = "1776", CategoryId = "mystery", Price = 4.50 },
                new Product { ProductId = 4, Title = "Band of Brothers", Description = "1776", CategoryId = "history", Price = 11.50 },
                new Product { ProductId = 5, Title = "Beloved", Description = "1776", CategoryId = "novel", Price = 10.99 },
                new Product { ProductId = 6, Title = "Between the World and Me", CategoryId = "memoir", Price = 13.50 },
                new Product { ProductId = 7, Title = "Bossypants", Description = "1776", CategoryId = "memoir", Price = 4.25 },
                new Product { ProductId = 8, Title = "Brave New World", Description = "1776", CategoryId = "scifi", Price = 16.25 },
                new Product { ProductId = 9, Title = "D-Day", CategoryId = "history", Description = "1776", Price = 15.00 },
                new Product { ProductId = 10, Title = "Down and Out in Paris and London", Description = "1776", CategoryId = "memoir", Price = 12.50 },
                new Product { ProductId = 11, Title = "Dune", Description = "1776", CategoryId = "scifi", Price = 8.75 },
                new Product { ProductId = 12, Title = "Emma", Description = "1776", CategoryId = "novel", Price = 9.00 },
                new Product { ProductId = 13, Title = "Frankenstein", Description = "1776", CategoryId = "scifi", Price = 6.50D },
                new Product { ProductId = 14, Title = "Go Tell it on the Mountain", Description = "1776", CategoryId = "novel", Price = 10.25 },
                new Product { ProductId = 15, Title = "Guns, Germs, and Steel", Description = "1776", CategoryId = "history", Price = 15.50 },
                new Product { ProductId = 16, Title = "Hunger", CategoryId = "memoir", Description = "1776", Price = 14.50 },
                new Product { ProductId = 17, Title = "Murder on the Orient Express", Description = "1776", CategoryId = "mystery", Price = 6.75 },
                new Product { ProductId = 18, Title = "Pride and Prejudice", Description = "1776", CategoryId = "novel", Price = 8.50 },
                new Product { ProductId = 19, Title = "Rebecca", Description = "1776", CategoryId = "mystery", Price = 10.99 },
                new Product { ProductId = 20, Title = "The Art of War", Description = "1776", CategoryId = "history", Price = 5.75 },
                new Product { ProductId = 21, Title = "The Girl with the Dragon Tattoo", Description = "1776", CategoryId = "mystery", Price = 8.50 },
                new Product { ProductId = 22, Title = "The Handmaid's Tale", Description = "1776", CategoryId = "scifi", Price = 12.50 },
                new Product { ProductId = 23, Title = "The Maltese Falcon", Description = "1776", CategoryId = "mystery", Price = 10.99 },
                new Product { ProductId = 24, Title = "The New Jim Crow", Description = "1776", CategoryId = "history", Price = 13.75 },
                new Product { ProductId = 25, Title = "The Year of Magical Thinking", Description = "1776", CategoryId = "memoir", Price = 13.50 },
                new Product { ProductId = 26, Title = "Wuthering Heights", Description = "1776", CategoryId = "novel", Price = 9.00 },
                new Product { ProductId = 27, Title = "Running With Scissors", Description = "1776", CategoryId = "memoir", Price = 11.00 },
                new Product { ProductId = 28, Title = "Pride and Prejudice and Zombies", Description = "1776", CategoryId = "novel", Price = 8.75 },
                new Product { ProductId = 29, Title = "Harry Potter and the Sorcerer's Stone", Description = "1776", CategoryId = "novel", Price = 9.75 }
            );
        }
    }

}
