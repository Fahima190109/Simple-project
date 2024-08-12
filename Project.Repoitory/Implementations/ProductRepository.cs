using Project.Models;
using Project.Repoitory.Interfaces;
using Project.Repoitory.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repoitory.Implementations
{
    public class ProductRepository : IProductRepository
    {
        public Task<bool> DeleteById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> getById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateById(long Id)
        {
            throw new NotImplementedException();
        }
    }
}
