using Smartphone_Shop.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Smartphone_Shop.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} can be at max {1} characters long.")]
        public string ModelName { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The {0} can be at max {1} characters long.")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        [Required]
        public int BrandId { get; set; }
        [Required]
        public int CpuId { get; set; }
        [Required]
        public int ColorId { get; set; }
        [Required]
        public int UsbTypeId { get; set; }
        [Required]
        public int SimTypeId { get; set; }
        [Required]
        public int DisplayTypeId { get; set; }
        [Required]
        public int OpSystemId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string DisplayRatio { get; set; }
        [Required]
        public double DisplaySize { get; set; }
        //in " (inch)
        [Required]
        public string DisplayRes { get; set; }
        //in px (pixel)
        [Required]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string Camera { get; set; }
        [Required]
        public int Ram { get; set; }
        //in GB (gigabyte)
        [Required]
        public int Battery { get; set; }
        //in mAh (milliampere/hour)
        [Required]
        public int Storage { get; set; }
        //in GB (gigabyte)
        [Required]
        public int Weight { get; set; }
        // in g (gram)    
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        public Boolean HotOffer { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        //in EUR (euro)
        public Brand Brand { get; set; }
        public Cpu Cpu { get; set; }
        public Color Color { get; set; }
        public UsbType UsbType { get; set; }
        public SimType SimType { get; set; }
        public DisplayType DisplayType { get; set; }
        public OpSystem OpSystem { get; set; }
    }
}   
