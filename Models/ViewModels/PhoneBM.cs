using System;

namespace Smartphone_Shop.Models.BusinessModel
{
    public class PhoneBM
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string BrandName { get; set; }
        public string CpuModel { get; set; }
        public double CpuFrequency { get; set; }
        public int CpuCores { get; set; }
        public string Gpu { get; set; } 
        public string ColorName { get; set; }
        public string UsbType { get; set; }
        public string SimType { get; set; }
        public string DisplayType { get; set; }
        public double DisplaySize { get; set; }
        public string OpSystem { get; set; }
        public string DisplayRatio { get; set; }
        public string DisplayRes { get; set; }
        public string Camera { get; set; }
        public int Ram { get; set; }
        public int Battery { get; set; }
        public int Storage { get; set; }
        public int Weight { get; set; }
        public string ReleaseDate { get; set; }
        public Boolean HotOffer { get; set; }
        public double Price { get; set; }
    }
}
