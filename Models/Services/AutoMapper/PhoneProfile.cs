using AutoMapper;
using Smartphone_Shop.Models.BusinessModel;
using Smartphone_Shop.Models.ViewModels;
using System.Collections.Generic;

namespace Smartphone_Shop.Models.AutoMapper
{
    public class PhoneProfile : Profile
    {
        public PhoneProfile()
        {
            CreateMap<List<Phone>, PhoneListViewModel>()
                .ForMember(x => x.Phones, y => y.MapFrom(PhonesToPhonesBM));

            CreateMap<Phone, PhoneBM>()
                .ForMember(x => x.CpuModel, y => y.MapFrom(z => z.Cpu.ModelName))
                .ForMember(x => x.BrandName, y => y.MapFrom(z => z.Brand.Name))
                .ForMember(x => x.DisplayType, y => y.MapFrom(z => z.DisplayType.Name))
                .ForMember(x => x.ColorName, y => y.MapFrom(z => z.Color.Name))
                .ForMember(x => x.OpSystem, y => y.MapFrom(z => z.OpSystem.Name))
                .ForMember(x => x.SimType, y => y.MapFrom(z => z.SimType.Name))
                .ForMember(x => x.UsbType, y => y.MapFrom(z => z.UsbType.Name))
                .ForMember(x => x.CpuFrequency, y => y.MapFrom(z => z.Cpu.Frequency))
                .ForMember(x => x.CpuCores, y => y.MapFrom(z => z.Cpu.NumOfCores))
                .ForMember(x => x.Gpu, y => y.MapFrom(z => z.Cpu.GraphicsChip));
        }

        private List<PhoneBM> PhonesToPhonesBM(List<Phone> entityList, PhoneListViewModel viewModel)
        {
            var phoneBMList = new List<PhoneBM>();

            foreach (var phone in entityList)
            {
                phoneBMList.Add(new PhoneBM()
                {
                    Id = phone.Id,
                    ModelName = phone.ModelName,
                    Description = phone.Description,
                    ImageUrl = phone.ImageUrl, 
                    BrandName = phone.Brand.Name,
                    CpuModel = phone.Cpu.ModelName,
                    CpuFrequency = phone.Cpu.Frequency,
                    CpuCores = phone.Cpu.NumOfCores,
                    Gpu = phone.Cpu.GraphicsChip,
                    ColorName = phone.Color.Name,
                    UsbType = phone.UsbType.Name,
                    SimType = phone.SimType.Name,
                    DisplayType = phone.DisplayType.Name,
                    DisplaySize = phone.DisplaySize,
                    OpSystem = phone.OpSystem.Name,
                    DisplayRatio = phone.DisplayRatio,
                    DisplayRes = phone.DisplayRes,
                    Camera = phone.Camera,
                    Ram = phone.Ram,
                    Battery = phone.Battery,
                    Storage = phone.Storage,
                    Weight = phone.Weight,
                    ReleaseDate = phone.ReleaseDate.ToString(),
                    HotOffer = phone.HotOffer,
                    Price = phone.Price
                });
            }
            return phoneBMList;
        }
    }
}
