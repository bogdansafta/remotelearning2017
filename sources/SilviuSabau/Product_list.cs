using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine_v1
{
    public class Product_list
    {
        private static Product_list instance;
        private Product_list(){}
        public static Product_list Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Product_list();
                }
                return instance;
            }
        }     
    }

}
