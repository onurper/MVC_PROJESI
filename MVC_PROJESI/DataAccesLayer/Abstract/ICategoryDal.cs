using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        List<Category> List();

        void Insert(Category category);

        void Update(Category category);

        void Delete(Category category);
    }
}
