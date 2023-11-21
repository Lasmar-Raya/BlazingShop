using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePatrick.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool IsPublic { get; set; } // when we add forums where we can add new items we can decide if this item still in draft mode or public (manage the visibility or status of items)

        public bool IsDeleted { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
