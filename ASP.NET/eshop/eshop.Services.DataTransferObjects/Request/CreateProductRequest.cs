using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Services.DataTransferObjects.Request
{
    public class CreateProductRequest
    {
        [Required(ErrorMessage = "Ürün adını unuttunuz :(")]
        [MaxLength(20)]
        [MinLength(3)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessage = "Ürün fiyatını unuttunuz :(")]

        public decimal Price { get; set; }

        public int Stock { get; set; } = 0;
        public string ImageUrl { get; set; } = "https://cdn.dsmcdn.com/ty337/product/media/images/20220221/21/54889095/393766841/5/5_org_zoom.jpg";

        public int CategoryId { get; set; }
    }
}
