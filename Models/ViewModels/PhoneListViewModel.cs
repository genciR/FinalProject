using Smartphone_Shop.Models.BusinessModel;
using System.Collections.Generic;

namespace Smartphone_Shop.Models.ViewModels
{
    public class PhoneListViewModel
    {
        public List<PhoneBM> Phones { get; set; }
        public List<BrandBM> Brands { get; set; }
    }

    
}
