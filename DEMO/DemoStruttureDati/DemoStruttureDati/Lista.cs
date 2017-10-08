using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStruttureDati
{
    public class Lista
    {
        private int count;
        private string[] items;        

        public Lista(int capacity = 10)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity));

            count = 0;
            items = new string[capacity];
        }

        public int Count { get { return count; }}

        public string GetItem(int index)
        {
            ValidateIndex(index);
            return items[index];
        }

        public void SetItem(int index, string value)
        {
            ValidateIndex(index);
            items[index] = value;
        }
        public void Add(string value)
        {
            if (count == items.Length)
            {
                var newCapacity = items.Length == 0 ? 10 : items.Length * 2;
                Array.Resize(ref items, newCapacity);
            }

            items[count++] = value;
        }

        public void Remove(string value) 
        {
            var index = Array.IndexOf(items, value, 0, count);
            if (index > -1)
                RemoveAt(index);
        }

        public void RemoveAt(int index) 
        {
            ValidateIndex(index);
            Array.Copy(items, index + 1, items, index, Count - index-1);
            count--;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(int value)
        {
            return Array.IndexOf(items, value, 0, Count) != -1;
        }

        public string[] ToArray()
        {
            var values = new string[Count];
            Array.Copy(items, 0, values, 0, Count);
            return values;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));
        }

    }
}
