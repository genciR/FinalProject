using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartphone_Shop.Models.Repositories
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly AppDbContext _db;

        public PhoneRepository(AppDbContext db)
        {
            this._db = db;
        }

        public List<Brand> allBrands
        {
            get { return _db.Brand.ToList(); }
        }
        public List<Phone> getAllPhones(int? brandId)
        {
            if(brandId.HasValue)
            {
                return _db.Phone.Include(x => x.Brand)
                                  .Include(x => x.Color)
                                  .Include(x => x.Cpu)
                                  .Include(x => x.SimType)
                                  .Include(x => x.UsbType)
                                  .Include(x => x.OpSystem)
                                  .Include(x => x.DisplayType).Where(y => y.BrandId == brandId).ToList();
            }
            else
            {
                return _db.Phone.Include(x => x.Brand)
                                  .Include(x => x.Color)
                                  .Include(x => x.Cpu)
                                  .Include(x => x.SimType)
                                  .Include(x => x.UsbType)
                                  .Include(x => x.OpSystem)
                                  .Include(x => x.DisplayType).ToList();
            }
            
        }

        public Phone getPhoneById(int phoneId)
        {
            return _db.Phone.Include(x => x.Brand)
                            .Include(x => x.Color)
                            .Include(x => x.Cpu)
                            .Include(x => x.SimType)
                            .Include(x => x.UsbType)
                            .Include(x => x.OpSystem)
                            .Include(x => x.DisplayType).FirstOrDefault(p => p.Id == phoneId);
        }

        public List<Phone> getHotOfferPhones() { 
            return _db.Phone.Include(x => x.Brand)
                            .Include(x => x.Color)
                            .Include(x => x.Cpu)
                            .Include(x => x.SimType)
                            .Include(x => x.UsbType)
                            .Include(x => x.OpSystem)
                            .Include(x => x.DisplayType).Where(y => y.HotOffer == true).ToList();
        }

        public void DeletePhone(int id)
        {
            var phone = _db.Phone.Find(id);
            _db.Phone.Remove(phone);
            _db.SaveChanges();
        }

        public void AddNewPhone(Phone phone)
        {
            _db.Phone.Add(phone);
            _db.SaveChanges();
        }
    }
}
