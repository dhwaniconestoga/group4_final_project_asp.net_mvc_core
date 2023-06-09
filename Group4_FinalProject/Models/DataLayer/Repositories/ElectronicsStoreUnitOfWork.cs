﻿using Group4_FinalProject.Models;
using System.Linq;

namespace Group4_FinalProject.Models
{
    public class ElectronicsStoreUnitOfWork : IElectronicsStoreUnitOfWork
    {
        private ElectronicsStoreContext context { get; set; }
        public ElectronicsStoreUnitOfWork(ElectronicsStoreContext ctx) => context = ctx;

        private Repository<Product> productData;
        public Repository<Product> Products
        {
            get
            {
                if (productData == null)
                    productData = new Repository<Product>(context);
                return productData;
            }
        }

        private Repository<Brand> brandData;
        public Repository<Brand> Brands
        {
            get
            {
                if (brandData == null)
                    brandData = new Repository<Brand>(context);
                return brandData;
            }
        }

        private Repository<ProductBrand> productbrandData;
        public Repository<ProductBrand> ProductBrands
        {
            get
            {
                if (productbrandData == null)
                    productbrandData = new Repository<ProductBrand>(context);
                return productbrandData;
            }
        }

        private Repository<Category> categoryData;
        public Repository<Category> Categories
        {
            get
            {
                if (categoryData == null)
                    categoryData = new Repository<Category>(context);
                return categoryData;
            }
        }

        private Repository<Order> Orderdata;
        public Repository<Order> Order
        {
            get
            {
                if (Orderdata == null)
                    Orderdata = new Repository<Order>(context);
                return Orderdata;
            }
        }

        public void DeleteCurrentProductBrands(Product product)
        {
            var currentBrands = ProductBrands.List(new QueryOptions<ProductBrand>
            {
                Where = ba => ba.ProductId == product.ProductId
            });
            foreach (ProductBrand ba in currentBrands)
            {
                ProductBrands.Delete(ba);
            }
        }

        public void LoadNewProductBrands(Product product, int[] brandids)
        {
            product.ProductBrands = brandids.Select(i =>
                new ProductBrand { Product = product, BrandId = i })
                .ToList();
        }

        public void Save() => context.SaveChanges();
    }
}
