using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group4_FinalProject.Models
{
    internal class SeedCategories : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasData(
                new Category { CategoryId = "novel", Name = "Novel" },
                new Category { CategoryId = "memoir", Name = "Memoir" },
                new Category { CategoryId = "mystery", Name = "Mystery" },
                new Category { CategoryId = "scifi", Name = "Science Fiction" },
                new Category { CategoryId = "history", Name = "History" }
            );
        }
    }

}
