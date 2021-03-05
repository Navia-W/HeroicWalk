using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreItemAttributes : MonoBehaviour
{
    public enum ItemType { shirt, hat }
    public ItemType itemType;
    public int itemPrice;
    public bool isLocked;
    public Texture2D itemSprite;

    public StoreItemAttributes(ItemType type, int price, string spriteName, bool locked)
    {
        itemType = type;
        itemPrice = price;
        isLocked = locked;

        itemSprite = (Texture2D)Resources.Load("Resources/" + spriteName);
    }
}
