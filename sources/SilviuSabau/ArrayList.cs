using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vending_machine_v1
{
    class OwnArraylist
    {
        private object[] inside_items;
        public OwnArraylist()
        {
            inside_items = new object[0];
        }

        public void ElementPrinting()
        {
            for (int i = 0; i < inside_items.Length; i++)
                Console.WriteLine(inside_items[i]);
        }

        public int Add(object value)
        {
            object[] inside_obj = new object[inside_items.Length + 1];
            for (int i = 0; i < inside_items.Length; i++)
                inside_obj[i] = inside_items[i];
            inside_obj[inside_obj.Length - 1] = value;
            inside_items = inside_obj;
            return inside_obj.Length - 1;
        }

        public int ItemIndex(object value, int startIndex)
        {
            for (int i = startIndex; i < inside_items.Length; i++)
            {
                if (inside_items[i].Equals(value))
                    return i;
            }
            return -1;
        }
        public int ItemIndex(object value)
        {
            return ItemIndex(value, 0);
        }

        public bool Contains(object value)
        {
            return ItemIndex(value) != -1;
        }

        public void Remove(object value)
        {
            if (!Contains(value))
            {
                return;
            }
            object[] inside_obj = new object[inside_items.Length - 1];
            bool deleted_item = false;
            for (int i = 0, j = 0; i < inside_obj.Length; i++, j++)
            {
                if (inside_items[i].Equals(value) && !deleted_item)
                {
                    j++;
                    deleted_item = true;
                }
                inside_obj[i] = inside_items[j];
            }
            inside_items = inside_obj;
        }

        public void Insert(int index, object value)
        {
            object[] inside_obj = new object[inside_items.Length + 1];
            if (index - 1 >= inside_items.Length + 1 || index < 0)
            {
                Console.WriteLine("Index not found");
                return;
            }
            for (int i = 0, j = 0; i < inside_obj.Length && j < inside_items.Length; i++, j++)
            {
                if (j == index - 1)
                {
                    inside_obj[j] = value;
                    i++;
                }
                inside_obj[inside_obj.Length - 1] = value;
                inside_obj[i] = inside_items[j];
            }
            inside_items = inside_obj;
        }
        public void RemoveAt(int index)
        {
            if (index >= inside_items.Length || index < 0)
            {
                Console.WriteLine("This type of index was not found in array");
                return;
            }
            object[] inside_obj = new object[inside_items.Length - 1];
            for (int i = 0, j = 0; i < inside_obj.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                inside_obj[i] = inside_items[j];
            }
            inside_items = inside_obj;
        }
    }
}


