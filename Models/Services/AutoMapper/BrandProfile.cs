using AutoMapper;
using Smartphone_Shop.Models.BusinessModel;
using Smartphone_Shop.Models.Repositories;
using Smartphone_Shop.Models.ViewModels;
using System.Collections.Generic;

namespace Smartphone_Shop.Models.Services.AutoMapper
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<List<Brand>, PhoneListViewModel>()
                .ForMember(x => x.Brands, y => y.MapFrom(BrandsToBrandsBM));
        }

        private List<BrandBM> BrandsToBrandsBM(List<Brand> entityList, PhoneListViewModel viewModel)
        {
            var brandBMList = new List<BrandBM>();

            foreach (var brand in entityList)
            {
                brandBMList.Add(new BrandBM()
                {
                    Id = brand.Id,
                    Name = brand.Name

                });
            }
            return brandBMList;
        }
    }
}
