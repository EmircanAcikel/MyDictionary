using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<I,S>
    {
        I[] key;
        S[] value;

        public MyDictionary()
        {
            key = new I[0];
            value = new S[0];

        }
        public void Add(I keys, S values)
        {
            I[] tempKey = key;
            S[] tempValue = value;

            key = new I[key.Length + 1];
            value = new S[value.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
            }
            key[key.Length - 1] = keys;
            value[value.Length - 1] = values;
        }
        public void WriteDictionary()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine(key[i]);
                Console.WriteLine(value[i]);
            }
            
        }

    }
}
