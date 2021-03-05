using UnityEngine;

[System.Serializable]
public class StoreItemAttributes
{
    public enum ItemType { shirt, hat }
    public ItemType itemType;
    public int itemPrice;
    public bool isLocked;
    public string itemName;
    public Texture2D itemSprite;

    public StoreItemAttributes(ItemType type, int price, string spriteName, bool locked)
    {
        itemType = type;
        itemPrice = price;
        isLocked = locked;
        itemName = spriteName;

        itemSprite = (Texture2D)Resources.Load("Resources/" + spriteName);
    }
}
