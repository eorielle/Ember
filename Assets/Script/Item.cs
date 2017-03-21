using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item  {

    public string name;
    public string description;
    public int id;
    public string iconPath;
    public List<int> types;
    public int price;
    
    public Item(string name, string description, int id = 0, string iconPath = "", List<int> types = null, int price = 10)
    {
        this.name = name;
        this.description = description;
        this.id = id;
        this.iconPath = iconPath;
        this.types = types;
        this.price = price;

    }

    // effects ?
    
}
