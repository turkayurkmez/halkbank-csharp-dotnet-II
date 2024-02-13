using eshop.Services.DataTransferObjects.Response;

namespace eshop.MVC.Models
{

    public class CardItem
    {
        public ProductForAddToCardResponse Product { get; set; }
        public int Quantity { get; set; }
    }
    public class ShoppingCardCollection
    {
        public List<CardItem> CardItems { get; set; }

        public void Add(CardItem item)
        {
            var existingItem = CardItems.FirstOrDefault(ci => ci.Product.Id == item.Product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                CardItems.Add(item);
            }
        }

        public decimal GetTotalPrice() => CardItems.Sum(p => p.Product.Price * p.Quantity);
        public int GetTotalQuantity() => CardItems.Sum(p => p.Quantity);


    }


}
