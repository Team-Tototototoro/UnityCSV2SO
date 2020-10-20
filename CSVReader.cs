using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class CSVReader
{
    private static TextAsset _currentCSVTextAsset;
    public static Dictionary<string, PrimitiveDataDictionary> _CSVDictionaries;

    public static void SetFile(TextAsset textAsset)
    {
        _currentCSVTextAsset = textAsset;
        ResetAndPopulateDictionary();
    }

    public static bool TryGetPrimitiveDictionary(string key, out PrimitiveDataDictionary dict)
    {
        return _CSVDictionaries.TryGetValue(key, out dict);
    }

    public static void ResetAndPopulateDictionary()
    {
        if(_currentCSVTextAsset == null) { return; }
        _CSVDictionaries = new Dictionary<string, PrimitiveDataDictionary>();

        string[] rows = _currentCSVTextAsset.text.Split('\n');
        string[] keys = rows[0].Split(',');

        for(int r = 1; r < rows.Length; r++)
        {
            PrimitiveDataDictionary primitiveDataDictionary = new PrimitiveDataDictionary();
            string[] columns = rows[r].Split(',');

            for(int c = 0; c < columns.Length; c++)
            {
                string key = keys[c].Trim();
                string primitiveDataString = columns[c];

                bool b;
                int i;
                float f;
                string s;

                b = primitiveDataString.ToLower().Equals("true");
                int.TryParse(primitiveDataString, out i);
                float.TryParse(primitiveDataString, out f);
                s = primitiveDataString.Trim();

                PrimitiveData primitiveData = new PrimitiveData(b, i, f, s);

                Debug.Log("DAN" + key + "DAN");
                primitiveDataDictionary.Add(key, primitiveData);
            }

            _CSVDictionaries.Add(columns[0], primitiveDataDictionary);

        }


    }

}
