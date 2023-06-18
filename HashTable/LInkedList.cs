﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class LinkedList<TKey, TValue>
    {
        public MyMapNode<TKey, TValue> Head { get; private set; }

        public void Insert(TKey key, TValue value)
        {
            var newNode = new MyMapNode<TKey, TValue>(key, value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                var current = Head;
                while (current.Next != null)
                {
                    if (current.Key.Equals(key))
                    {
                        current.Value = value;
                        return;
                    }
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Traverse()
        {
            var current = Head;
            while (current != null)
            {
                Console.WriteLine($"{current.Key}: {current.Value}");
                current = current.Next;
            }
        }
}   }
