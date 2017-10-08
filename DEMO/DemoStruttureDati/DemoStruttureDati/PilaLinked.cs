using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStruttureDati
{
    public class PilaLinked
    {
        class Item
        {
            public string Value;
            public Item Prev;
        }

        private Item head = null;
        private int count;
        public PilaLinked()
        {
            head = null;
            count = 0;
        }
        public void Push(string value)
        {
            var item = new Item { Value = value, Prev = head };            
            head = item;
            count++;
        }
        public string Pop() 
        {
            if (IsEmpty)
                throw new InvalidOperationException("La pila è vuota");
            var valore = head.Value;
            head = head.Prev;
            count--;
            return valore;
        }
        public string Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("La pila è vuota");
            return head.Value;
        }

        public bool IsEmpty
        {
            get { return head == null; }
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(string value)
        {
            var item = head;
            while(item != null)
            {
                if (item.Value == value)
                    return true;
                item = item.Prev;
            }
            return false;
        }

        public string[] ToArray()
        {
            var values = new string[count];
            var item = head;
            var i = 0;
            while (item != null)
            {
                values[i++] = item.Value;
                item = item.Prev;
            }
            
            return values;
        }        
    }
}
