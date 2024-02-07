using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanism
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }


    }

    public class ProductCreatedEventArgs : EventArgs
    {
        public DateTime CreatedDate { get; set; }
        public Product Product { get; set; }
        public string User { get; set; }
    }

    public class ProductService
    {
        //public delegate void ProductCreateEventHandler(object sender, ProductCreatedEventArgs e);
        public event EventHandler<ProductCreatedEventArgs> ProductCreated;
        public void Add(Product product)
        {
            //db'ye eklendi.....

            ProductCreatedEventArgs productCreatedEventArgs = new ProductCreatedEventArgs()
            {
                CreatedDate = DateTime.Now,
                Product = product,
                User = "turkay"
            };

            onCreated(productCreatedEventArgs);

        }

        private void onCreated(ProductCreatedEventArgs productCreatedEventArgs)
        {
            if (ProductCreated != null)
            {
                ProductCreated(this, productCreatedEventArgs);
            }
        }
    }
}
