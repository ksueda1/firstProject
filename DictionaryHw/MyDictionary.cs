﻿using System;
using System.Collections.Generic;

namespace DictionaryHw
{
    public class MyDictionary<TKey, TValue>

    {
        TKey[] keys;
        TValue[] values;
        TKey[] tempKeys;
        TValue[] tempValues;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];

        }

        public void Add(TKey key, TValue value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
    }
}
