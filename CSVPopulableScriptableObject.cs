using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Inherit CSV data scriptable objects from this class.
/// </summary>
public abstract class CSVPopulableScriptableObject : ScriptableObject
{
#if UNITY_EDITOR
    //TextAsset for the relevant CSV file.
    [SerializeField] private TextAsset CSV;

    /// <summary>
    /// Key from which to read data.
    /// </summary>
    public abstract string CSVKey { get; }

    /// <summary>
    /// Editor button that populates CSV data into appropriate fields.
    /// </summary>
    [Button("Populate CSV")]
    public void PopulateFromCSV()
    {
        if (CSV == null)
        {
            Debug.LogError("No CSV!");
            return;
        }
        CSVReader.SetFile(CSV);
        PrimitiveDataDictionary dictionary;

        if (CSVReader.TryGetPrimitiveDictionary(CSVKey, out dictionary))
        {
            PopulateData(dictionary);
        }
        else
        {
            string[] keys = new string[CSVReader._CSVDictionaries.Keys.Count];
            CSVReader._CSVDictionaries.Keys.CopyTo(keys, 0);
            Debug.LogError("Couldn't find data!" + keys[0]);
            return;
        }
    }
    /// <summary>
    /// Abstract function that handles the data population per child class.
    /// </summary>
    /// <param name="dataDictionary"></param>
    protected abstract void PopulateData(PrimitiveDataDictionary dataDictionary);
#endif
}