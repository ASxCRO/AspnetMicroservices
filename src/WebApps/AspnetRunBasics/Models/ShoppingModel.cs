using System.Collections.Generic;

namespace AspnetRunBasics.Models
{
    public class ShoppingModel
    {
        public string UserName { get; set; }
        public BasketModel BasketWithProducts { get; set; }
        public IEnumerable<OrderResponseModel> Orders { get; set; }
    }
}
