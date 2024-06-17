using System.Collections.Generic;

namespace Smartphone_Shop.Models.Repositories
{
    public interface IPhoneRepository
    {
        public List<Phone> getAllPhones(int? brandId);
        public Phone getPhoneById(int phoneId);
        public List<Phone> getHotOfferPhones();

        public List<Brand> allBrands { get; }
        public void DeletePhone(int id);
        public void AddNewPhone(Phone phone);
    }
}
