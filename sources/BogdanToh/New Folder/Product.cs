using System;

namespace New_Folder
{
    public class Product
    {
        public string TypeOfProduct { get; set; } = "Unknown";
        public string Name { get; set; } = "Product";
        public double Price { get; set; } = 5;

        public int Quantity { get; set; } = 0;
        public int NrOfCells { get; set; } = 0;
        public override string ToString()
        {
            return $@" 
                       Type: {this.TypeOfProduct}
                       Name: {this.Name} 
                       Price: {this.Price}
                       Quantity: {this.Quantity}
                       Cells: {this.NrOfCells}";
        }
    }




}