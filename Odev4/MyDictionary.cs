using System;
using System.Collections.Generic;
using System.Text;

namespace Odev4
{
    class MyDictionary<K, T>
    {
        T[] items;
        K[] keys;

        public MyDictionary()
        {
            items = new T[0];
            keys = new K[0];
        }
        public void Add(K key, T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

            K[] tempArray2 = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                keys[i] = tempArray2[i];
            }
            keys[keys.Length - 1] = key;
        }
        public void List()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(keys[i] + " no'lu öğrencimiz: " + items[i]);

            }

        }
        public void ID()
        {
            foreach(var Id in keys)
            {
                Console.WriteLine("Öğrencilerin ID Değerleri: "+ Id);
            }

        } 

        public int Count // Biz bu MyDictionary'nin Count'unu çağırırsak o da bize bu keys'in eleman sayısını verir.
        {
            get { return keys.Length; }
        }
    }
}
