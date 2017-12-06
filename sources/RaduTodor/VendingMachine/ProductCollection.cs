namespace VendingMachine
{
    internal class ProductCollection
    {
        int Size { get; set; }
        Node First;
        public Node GetFirst()=>First;

        public ProductCollection()
        {
            Size = 0;
            First = null;
        }

        public Node FindPrev(Product stranger)//string tip, string nume)
        {
            Node Temp = First;
            for (int i = 0; i < Size; i++)
                if (Temp.To != null && Temp.To.Product.Equals(stranger))//Temp.To.Product.Gettype() == tip && Temp.To.Product.GetName() == nume)
                    return Temp;
                else
                    Temp = Temp.To;
            return null;
        }

        public void Add(Product New)
        {
            Node Same = FindPrev(New);
            if (Same != null)
                Same.To.Product.SetQuantity(Same.To.Product.GetQuantity() + New.GetQuantity());
            else
            {
                Size++;
                Node Temp = new Node(New, First);
                First = Temp;
            }
        }
        public void Remove(Product stranger)
        {
            if (First.Product.Equals(stranger))
            {
                First = First.To;
                Size--;
            }
            else
            {

                Node Temp = FindPrev(stranger);
                if (Temp != null)
                {
                    Temp.To = Temp.To.To;
                    Size--;
                }
            }
        }
        public int Count()
        {
            return Size;
        }
    }

}