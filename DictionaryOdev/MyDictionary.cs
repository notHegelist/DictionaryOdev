using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{

    public class MyDictionary<TKey, TValue>
    {
        TKey[] _arrayK;
        TKey[] _tempArrayK;
        TValue[] _arrayV;
        TValue[] _tempArrayV;


        public MyDictionary()
        {
            _arrayK = new TKey[0];
            _arrayV = new TValue[0];
        }
        public void Add(TKey plaque, TValue city)
        {
            _tempArrayK = _arrayK;
            _tempArrayV = _arrayV;
            _arrayK = new TKey[_arrayK.Length + 1];
            _arrayV = new TValue[_arrayV.Length + 1];

            for (int i = 0; i < _tempArrayK.Length; i++)
            {
                _arrayK[i] = _tempArrayK[i];
                _arrayV[i] = _tempArrayV[i];
            }
            _arrayK[_arrayK.Length - 1] = plaque;
            _arrayV[_arrayV.Length - 1] = city;
        }
        public int Count
        {
            get { return _arrayK.Length; }
        }
        public TValue this[TKey plaque]
        {
            get
            {
                return _arrayV[Array.IndexOf(_arrayK, plaque)];
            }
        }





    }




}
