using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine_v1
{
    internal class Product : IEquatable<Product>
    {
        private string category;
        private string name;
        private float price;
        private int quantity;
        private Tuple<float, float> size;
        private string bar_code;
        Product()
        {
            category = null;
            name = null;
            price = 0;
            quantity = 0;
            setSize(new Tuple<float, float>(0, 0));
            bar_code = null;
        }
        Product(string own_category, string own_name, float own_price, int own_quantity, float lungime, float latime, string own_barCode)
        {
            category = own_category;
            name = own_name;
            price = own_price;
            quantity = own_quantity;
            setSize(new Tuple<float,float>(lungime,latime));
            bar_code = own_barCode;
        }
        ~Product()
        {

        }
        public void setCategory(string setValue)
        {
            this.category = setValue;
        }
        public string getCategory()
        {
            return this.category;
        }
        public double getPrice()
        {
            return this.price;
        }
        public void setPrice(float setValue)
        {
            this.price = setValue;
        }
        public void setName(string setValue)
        {
            this.name = setValue;
        }
        public string getName()
        {
            return this.name;
        }
        public void setQuantity(int setValue)
        {
            this.quantity = setValue;
        }
        public int getQuantity()
        {
            return this.quantity;
        }
        public void setSize(Tuple<float,float> setValue)
        {
            this.size = setValue;
        }
        public Tuple <float,float> getSize()
        {
            return this.size;
        }
        public void setBarcode(string setValue)
        {
            this.bar_code = setValue;
        }
        public string getBarcode()
        {
            return this.bar_code;
        }
        bool IEquatable<Product>.Equals(Product own_product)
        {
            if (this.name == own_product.name && this.category == own_product.category && this.size == own_product.size && this.quantity == own_product.quantity && this.price == own_product.price)
                return true;
            return false;
        }
    }
}
