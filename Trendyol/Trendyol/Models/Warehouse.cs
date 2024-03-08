using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trendyol.Models
{
    public class Warehouse : BaseEntity
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Count { get; set; }

        public ObservableCollection<Product> Products;
    }
}
