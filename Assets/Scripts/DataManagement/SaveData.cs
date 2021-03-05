using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    Type staticManager = typeof(StaticManager);

    public static SaveData saveData;

    private void Awake()
    {
        if (saveData != null)
            return;

        saveData = this;
    }

    public void GetVariables()
    {
        FieldInfo[] staticFields = staticManager.GetFields();

        for (int i = 0; i < staticFields.Length; i++)
        {
            SaveProgress(staticFields[i].Name, staticFields[i].GetValue(i).ToString());
        }
    }

    private static void SaveProgress(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
        PlayerPrefs.Save();
        Debug.Log("Data saved");
    }
}
