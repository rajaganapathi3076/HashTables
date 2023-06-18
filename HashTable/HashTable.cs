using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTable<TKey, TValue>
    {
        private const int Capacity = 10;
        private LinkedList<TKey, TValue>[] buckets;

        public HashTable()
        {
            buckets = new LinkedList<TKey, TValue>[Capacity];
            for (int i = 0; i < Capacity; i++)
            {
                buckets[i] = new LinkedList<TKey, TValue>();
            }
        }

        private int GetHash(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % Capacity;
        }

        public void Insert(TKey key, TValue value)
        {
            int index = GetHash(key);
            buckets[index].Insert(key, value);
        }
        public void Remove(TKey key)
        {
            int index = GetHash(key);
            buckets[index].Remove(key);
        }


        public TValue GetFrequency(TKey key)
        {
            int index = GetHash(key);
            var current = buckets[index].Head;
            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return default(TValue);
        }
    }
}       
