using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//Root Object class 
// I took off the Group List since we don't use it
[Serializable]
public class RootObject
{
    public List<Security> securities;

    public IEnumerator<Security> GetEnumerator()
    {
        return securities.GetEnumerator();
    }
}
