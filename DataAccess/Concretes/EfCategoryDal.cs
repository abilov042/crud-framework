using Core.DataAccess;
using Dao.Abstracts;
using Entity.Concretes;

namespace Dao.Concretes;

public class EfCategoryDal: EfEntityRepository<Category, NorthwindDbContext>, ICategoryDal
{
    
}