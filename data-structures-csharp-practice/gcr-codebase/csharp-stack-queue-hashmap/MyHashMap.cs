using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.stackqueuehashmap
{
    internal class MyHashMap<TKey, TValue>
    {
        private const int DEFAULT_CAPACITY = 16;
        private LinkedList<KeyValuePair<TKey, TValue>>[] buckets;

        public MyHashMap()
        {
            buckets = new LinkedList<KeyValuePair<TKey, TValue>>[DEFAULT_CAPACITY];
        }

        private int GetBucketIndex(TKey key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            return Math.Abs(key.GetHashCode()) % buckets.Length;
        }

        // Insert or Update
        public void Put(TKey key, TValue value)
        {
            int index = GetBucketIndex(key);

            if (buckets[index] == null)
                buckets[index] = new LinkedList<KeyValuePair<TKey, TValue>>();

            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                {
                    buckets[index].Remove(pair);
                    buckets[index].AddLast(new KeyValuePair<TKey, TValue>(key, value));
                    return;
                }
            }

            buckets[index].AddLast(new KeyValuePair<TKey, TValue>(key, value));
        }

        // Retrieve
        public TValue Get(TKey key)
        {
            int index = GetBucketIndex(key);

            if (buckets[index] != null)
            {
                foreach (var pair in buckets[index])
                {
                    if (pair.Key.Equals(key))
                        return pair.Value;
                }
            }

            throw new KeyNotFoundException("Key not found");
        }

        // Delete
        public bool Remove(TKey key)
        {
            int index = GetBucketIndex(key);

            if (buckets[index] != null)
            {
                var node = buckets[index].First;
                while (node != null)
                {
                    if (node.Value.Key.Equals(key))
                    {
                        buckets[index].Remove(node);
                        return true;
                    }
                    node = node.Next;
                }
            }

            return false;
        }
    }
}
