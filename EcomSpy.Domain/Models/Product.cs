using System;
using System.ComponentModel.DataAnnotations;

namespace EcomSpy.Domain.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required, MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required, MaxLength(100)]
        public string StoreName { get; set; }

        [Required, Url, MaxLength(500)]
        public string StoreLink { get; set; }
    }
}
