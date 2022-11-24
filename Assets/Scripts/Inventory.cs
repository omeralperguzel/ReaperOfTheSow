using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    //Our Array List
    private List<Item> itemList;

    //Constructer
    public Inventory()
    {
        itemList = new List<Item>();
    }

    public void AddItem(Item item)
    {
        itemList.Add(item);
    }
}
