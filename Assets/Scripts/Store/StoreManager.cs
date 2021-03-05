using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    private List<StoreItemAttributes> _lockedItems = new List<StoreItemAttributes>();
    private List<StoreItemAttributes> _unlockedItems = new List<StoreItemAttributes>();
    private List<StoreItemAttributes> _itemList = new List<StoreItemAttributes>();

    private StoreItemAttributes _item;

    private void Awake()
    {
        for (int i = 0; i < StoreItemManager.itemList.Count; i++)
        {
            if (StoreItemManager.itemList[i].isLocked)
                _lockedItems.Add(StoreItemManager.itemList[i]);
            else
                _unlockedItems.Add(StoreItemManager.itemList[i]);
        }
        for (int j = 0; j < _lockedItems.Count; j++)
        {
            _itemList.Add(_lockedItems[j]);
        }
        for (int k = 0; k < _unlockedItems.Count; k++)
        {
            _itemList.Add(_unlockedItems[k]);
        }
    }

    private int _currentItem = 0;

    public void SelectItem(int next)
    {
        if (_currentItem + next > _itemList.Count - 1)
        {
            _currentItem = 0;
            _item = _itemList[_currentItem];
        }
        else if (_currentItem + next < 0)
        {
            _currentItem = _itemList.Count - 1;
            _item = _itemList[_currentItem];
        }
        else
        {
            _currentItem += next;
            _item = _itemList[_currentItem];
        }
    }

    private int _playerScore;

    public void BuyItem(int itemIndex)
    {
        if (_playerScore >= _itemList[itemIndex].itemPrice && _itemList[itemIndex].isLocked)
        {
            _playerScore -= _itemList[itemIndex].itemPrice;
            _itemList[itemIndex].isLocked = false;
        }

        SaveInventory(_itemList[itemIndex].name);
    }


    Type staticManager = typeof(StaticManager);

    public void SaveInventory(string itemName)
    {
        FieldInfo[] staticFields = staticManager.GetFields();
        
        for (int i = 0; i < staticFields.Length; i++)
        {
            if (staticFields[i].Name.Contains(itemName))
            {
                staticFields[i].SetValue(staticFields[i].Name, true);

                SaveData.saveData.GetVariables();
            }
        }
    }
}
