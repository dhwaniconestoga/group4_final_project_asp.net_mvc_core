using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group4_FinalProject.Models
{
    internal class SeedProductBrands : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> entity)
        {
            entity.HasData(
                new ProductBrand { ProductId = 1, BrandId = 18 },
                new ProductBrand { ProductId = 2, BrandId = 20 },
                new ProductBrand { ProductId = 3, BrandId = 7 },
                new ProductBrand { ProductId = 4, BrandId = 2 },
                new ProductBrand { ProductId = 5, BrandId = 19 },
                new ProductBrand { ProductId = 6, BrandId = 8 },
                new ProductBrand { ProductId = 7, BrandId = 12 },
                new ProductBrand { ProductId = 8, BrandId = 16 },
                new ProductBrand { ProductId = 9, BrandId = 2 },
                new ProductBrand { ProductId = 10, BrandId = 20 },
                new ProductBrand { ProductId = 11, BrandId = 15 },
                new ProductBrand { ProductId = 12, BrandId = 4 },
                new ProductBrand { ProductId = 13, BrandId = 21 },
                new ProductBrand { ProductId = 14, BrandId = 5 },
                new ProductBrand { ProductId = 15, BrandId = 9 },
                new ProductBrand { ProductId = 16, BrandId = 13 },
                new ProductBrand { ProductId = 17, BrandId = 7 },
                new ProductBrand { ProductId = 18, BrandId = 4 },
                new ProductBrand { ProductId = 19, BrandId = 11 },
                new ProductBrand { ProductId = 20, BrandId = 22 },
                new ProductBrand { ProductId = 21, BrandId = 17 },
                new ProductBrand { ProductId = 22, BrandId = 3 },
                new ProductBrand { ProductId = 23, BrandId = 14 },
                new ProductBrand { ProductId = 24, BrandId = 1 },
                new ProductBrand { ProductId = 25, BrandId = 10 },
                new ProductBrand { ProductId = 26, BrandId = 6 },
                new ProductBrand { ProductId = 27, BrandId = 23 },
                new ProductBrand { ProductId = 28, BrandId = 4 },
                new ProductBrand { ProductId = 28, BrandId = 26 },
                new ProductBrand { ProductId = 29, BrandId = 25 }
            );
        }
    }

}
