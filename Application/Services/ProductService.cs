using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CleanArch.Onion.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public async Task CreateProductAsync(ProductDTO productDTO)
        {
            var product = new Product { Name = productDTO.Name, Price = productDTO.Price };
            await _productRepository.AddAsync(product);
            
        }
    }
}