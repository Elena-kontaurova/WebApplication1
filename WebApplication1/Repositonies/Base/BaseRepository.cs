using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebApplication1.Data;
using WebApplication1.Models.Base;

namespace WebApplication1.Repositonies.Base
{
    public abstract class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : BaseModel
    {
        protected readonly ApplicationContext _context;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public EntityEntry<TModel> Create(TModel model)
        {
            return _context.Set<TModel>().Add(model);
        }

        public void Delete(TModel model)
        {
            _context.Set<TModel>().Remove(model);
        }

        public List<TModel> GetAll()
        {
            return _context.Set<TModel>().ToList();
        }

        public TModel GetById(int id)
        {
            return _context.Set<TModel>().FirstOrDefault(model => model.Id == id);
        }

        public TModel GetByName(string name)
        {
            return _context.Set<TModel>().FirstOrDefault(model => model.Name == name);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public EntityEntry<TModel> Update(TModel model)
        {
            return _context.Set<TModel>().Update(model);
        }
    }
}
