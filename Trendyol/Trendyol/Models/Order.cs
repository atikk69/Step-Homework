using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Views;

namespace Trendyol.Models
{
     class Order
     {
        [Key]
        public int Id { get; set; }
        [Required,ForeignKey("Users")]
        public int UserId { get; set; }
        [Required,ForeignKey("Products")]
        public int ProductId { get; set; }
        [Required]
        public int ProductsCount { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public float TotalPrice { get; set; }
     }
}
