
using BookStore.Models.Attributes;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.DTOs.VM
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public int ProductTypeId { get; set; }

        public string ProductTypeName { get; set; }

        public List<IdNameDto> ProductTypes { get; set; }

        [AllowedExtensions(".jpg", ".png", ".jpeg")]
        [MaxFileSize(10 * 1024 *1024)]
        public IFormFile ProductImage { get; set; }
    }
}
