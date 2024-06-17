using BulkeyBook.DataAccess.Data;
using BulkeyBook.DataAccess.Repository.IRepository;
using BulkeyBook.Models;


namespace BulkeyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
