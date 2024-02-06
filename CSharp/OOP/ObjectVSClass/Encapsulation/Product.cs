using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private decimal price;

        public void SetPrice(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Fiyat değeri negatif olamaz!");
            }

            this.price = value;
        }

        public decimal GetPrice()
        {
            return this.price;
        }


        private string name;
        public string Name
        {
            set
            {

                name = value;
            }
            get { return this.name; }

        }

        public string Description { get; set; }

        public int StockCount { get; private set; }

        public void IncreaseStock(int value)
        {
            StockCount += value;
        }

    }
}
