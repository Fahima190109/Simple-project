using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repoitory.Interfaces.Base
{
    public interface IGenericRepoitory<T> where T : class
    {
        Task<T> getById(long Id);
        Task<List<T>> getAll();
        Task<bool> DeleteById(long Id);
        Task<bool> UpdateById(long Id);
    }
}
