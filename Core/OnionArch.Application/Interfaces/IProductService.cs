using OnionArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Application.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
