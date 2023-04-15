using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group4_FinalProject.Models
{
    internal class SeedBrands : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> entity)
        {
            entity.HasData(
                new Brand { BrandId = 1, Name = "Michelle"},
                new Brand { BrandId = 2, Name = "Stephen E."},
                new Brand { BrandId = 3, Name = "Margaret"},
                new Brand { BrandId = 4, Name = "Jane"},
                new Brand { BrandId = 5, Name = "James"},
                new Brand { BrandId = 6, Name = "Emily"},
                new Brand { BrandId = 7, Name = "Agatha"},
                new Brand { BrandId = 8, Name = "Ta-Nehisi"},
                new Brand { BrandId = 9, Name = "Jared"},
                new Brand { BrandId = 10, Name = "Joan"},
                new Brand { BrandId = 11, Name = "Daphne"},
                new Brand { BrandId = 12, Name = "Tina"},
                new Brand { BrandId = 13, Name = "Roxane"},
                new Brand { BrandId = 14, Name = "Dashiel"},
                new Brand { BrandId = 15, Name = "Frank"},
                new Brand { BrandId = 16, Name = "Aldous"},
                new Brand { BrandId = 17, Name = "Stieg"},
                new Brand { BrandId = 18, Name = "David"},
                new Brand { BrandId = 19, Name = "Toni"},
                new Brand { BrandId = 20, Name = "George"},
                new Brand { BrandId = 21, Name = "Mary"},
                new Brand { BrandId = 22, Name = "Sun"},
                new Brand { BrandId = 23, Name = "Augusten"},
                new Brand { BrandId = 25, Name = "JK"},
                new Brand { BrandId = 26, Name = "Seth"}
            );
        }
    }

}
       