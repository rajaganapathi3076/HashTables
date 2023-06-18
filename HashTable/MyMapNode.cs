﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class MyMapNode<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public MyMapNode<TKey, TValue> Next { get; set; }

        public MyMapNode(TKey key, TValue value)
        {
            Key = key;
            Value = value;
            Next = null;
        }

    }
}
