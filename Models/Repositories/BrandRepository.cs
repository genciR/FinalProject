using System.Collections.Generic;
using System.Linq;

namespace Smartphone_Shop.Models.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly AppDbContext _db;

        public BrandRepository(AppDbContext db)
        {
            this._db = db;
        }

        public List<Brand> allBrands 
        {
            get { return _db.Brand.ToList(); }
        }
    }
}
