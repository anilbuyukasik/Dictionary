using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<XKey, XVal>
    {
        XKey[] keys;
        XVal[] vals;
        string result;

        public MyDictionary()
        {
            keys = new XKey[0];
            vals = new XVal[0];
        }
        public void Add(XKey key, XVal val)
        {
            XKey[] tempArrayKey = keys;
            keys = new XKey[keys.Length + 1];

            XVal[] tempArrayVal = vals;
            vals = new XVal[vals.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[i] = tempArrayKey[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempArrayVal.Length; i++)
            {
                vals[i] = tempArrayVal[i];
            }
            vals[vals.Length - 1] = val;

        }
        public int Length
        {
            get { return keys.Length; }
        }
    }
}
