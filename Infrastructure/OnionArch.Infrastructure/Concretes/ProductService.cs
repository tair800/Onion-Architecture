using OnionArch.Application.Interfaces;
using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Infrastructure.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() => new()
        {
            new(){Id=1,Name="Product1"},
            new(){Id=2,Name="Product2"},
            new(){Id=3,Name="Product3"},
        };
    }
}
