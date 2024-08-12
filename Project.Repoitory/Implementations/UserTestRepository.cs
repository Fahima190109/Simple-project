using Project.Models;
using Project.Repoitory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repoitory.Implementations
{
    public class UserTestRepository : IUserTestRepository
    {
        public Task<bool> DeleteById(long Id)
        {
            throw new NotImplementedException();
        }

        //public Task<List<UserTestDTO>> getAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<UserTestDTO> getById(long Id)
        //{
        //    throw new NotImplementedException();
        //}
        public Task<List<UserTestDTO>> getAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserTestDTO> getById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateById(long Id)
        {
            throw new NotImplementedException();
        }
    }
}
