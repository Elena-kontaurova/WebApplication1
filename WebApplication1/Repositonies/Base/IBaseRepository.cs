using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApplication1.Models.Base;

namespace WebApplication1.Repositonies.Base
{
    public interface IBaseRepository<TModel> where TModel : BaseModel
    {
        List<TModel> GetAll();
        TModel GetById(int id);
        TModel GetByName(string name);
        EntityEntry<TModel> Create(TModel model);
        EntityEntry<TModel> Update(TModel model);
        void Delete(TModel model);
        void SaveChanges();

    }
}
