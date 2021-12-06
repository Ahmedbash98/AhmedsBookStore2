using AhmedsBooks.DataAccess.Repository.IRepository;
using AhmedsBooks.Models;
using AhmedsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhmedsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       // public void Add(CoverType coverType)
        //{
        //    throw new NotImplementedException();
       // }

        public void Update(Category category)
        {
            //use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Catgories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
            }
        }
    }
}