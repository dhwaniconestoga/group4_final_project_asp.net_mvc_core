namespace Group4_FinalProject.Models
{
    public interface IElectronicsStoreUnitOfWork
    {
        Repository<Product> Products { get; }
        Repository<Brand> Brands { get; }
        Repository<ProductBrand> ProductBrands { get; }
        Repository<Category> Categories { get; }

        void DeleteCurrentProductBrands(Product product);
        void LoadNewProductBrands(Product product, int[] brandids);
        void Save();
    }
}
