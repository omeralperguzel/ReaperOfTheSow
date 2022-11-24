using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        Wood,
        Plastic,
        Glass,
        Metal,
    }

    public ItemType itemType;
    public int amount;
}
