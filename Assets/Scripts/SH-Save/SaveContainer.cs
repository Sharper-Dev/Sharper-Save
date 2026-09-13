using System;
using UnityEngine;

namespace SHSave
{
    /// <summary>
    /// The save container that stores the SaveData class.
    /// </summary>
    [CreateAssetMenu(fileName = "Save Container", menuName = "SH-Save/Save Container")]
    public class SaveContainer : ScriptableObject
    {
        public SaveData saveData;
    }
    /// <summary>
    /// A serializable class to store data.
    /// </summary>
    [Serializable]
    public class SaveData
    {
        //Sample data
        public int intData;
        public float floatData;
        public bool boolData;
        public string stringData;
    }
}