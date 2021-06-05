using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesBook.Models.Database.Base
{
    public interface IRepository<T>
    {
        void Save(T item);
        ICollection<T> GetAll();
    }
}
