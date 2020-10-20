using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimitiveDataDictionary : Dictionary<string, PrimitiveData>
{
    public PrimitiveDataDictionary() : base() { }

    public bool TryGetBool(string key, out bool b)
    {
        if (TryGetValue(key, out PrimitiveData pData))
        {
            b = pData.Bool;
            return true;
        }
        b = false;
        return false;
    }
    public bool TryGetInt(string key, out int i)
    {
        if (TryGetValue(key, out PrimitiveData pData))
        {
            i = pData.Int;
            return true;
        }
        i = -1;
        return false;
    }
    public bool TryGetFloat(string key, out float f)
    {

        Debug.Log("KEY: " + key + " -- contained? " + ContainsKey(key));

        if (TryGetValue(key, out PrimitiveData pData))
        {
            f = pData.Float;
            return true;
        }
        f = -1f;
        return false;
    }
    public bool TryGetString(string key, out string s)
    {

        Debug.Log("KEY: " + key + " -- contained? " + ContainsKey(key));

        if (TryGetValue(key, out PrimitiveData pData))
        {
            s = pData.String;
            return true;
        }
        s = "";
        return false;
    }
}
