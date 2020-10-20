using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PrimitiveData
{
    public bool Bool { get; private set; }
    public int Int { get; private set; }
    public float Float { get; private set; }
    public string String { get; private set; }
    public PrimitiveData(bool pBool, int pInt, float pFloat, string pString)
    {
        Bool = pBool;
        Int = pInt;
        Float = pFloat;
        String = pString;
    }
}