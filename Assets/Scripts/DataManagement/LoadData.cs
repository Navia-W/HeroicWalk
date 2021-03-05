using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LoadData : MonoBehaviour
{
    Type staticManager = typeof(StaticManager);

    public static LoadData loadData;

    private void Awake()
    {
        if (loadData != null)
            return;

        loadData = this;
    }

    public void GetVariables()
    {
        FieldInfo[] staticFields = staticManager.GetFields();

        for (int i = 0; i < staticFields.Length; i++)
        {
            LoadProgress(staticFields[i].Name);
        }
    }

    private static void LoadProgress(string key)
    {
        Type staticManager = typeof(StaticManager);

        if (PlayerPrefs.HasKey(key))
        {
            FieldInfo[] staticFields = staticManager.GetFields();

            for (int i = 0; i < staticFields.Length; i++)
            {
                if (staticFields[i].Name == key)
                {
                    staticFields[i].SetValue(staticFields[i].Name, int.Parse(PlayerPrefs.GetString(key)));
                }
            }
        }
    }
}
