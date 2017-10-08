using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStruttureDati
{
    public class Pila
    {
        private int head;
        private string[] items;        

        public Pila(int capacity = 10)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));

            head = -1;
            items = new string[capacity];
        }

        public int Count { get { return head + 1; }}
        public void Push(string value)
        {
            if (head == items.Length - 1)
            {
                var newCapacity = items.Length == 0 ? 10 : items.Length * 2;
                Array.Resize(ref items, newCapacity);
            }

            items[++head] = value;
        }

        public string Pop() 
        {
            if (IsEmpty)
                throw new InvalidOperationException("La pila è vuota");
            return items[head--];
        }

        public string Peek() 
        {
            if (IsEmpty)
                throw new InvalidOperationException("La pila è vuota");
            return items[head];
        }

        public void Clear()
        {
            head = -1;
        }

        public bool Contains(int value)
        {
            return Array.IndexOf(items, value, 0, Count) != -1;
        }

        public string[] ToArray()
        {
            var values = new string[Count];
            for (int i = head; i >=0; i--)
            {
                values[Count-i-1] = items[i];
            }
            return values;
        }

        public bool IsEmpty
        {
            get { return head == -1; }
        }

    }
}
