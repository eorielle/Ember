using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    private Dictionary<Item, int> list = new Dictionary<Item, int>();

    public void AddItem(Item item)
    {
        if (list.ContainsKey(item))
        {
            list[item]++;
        }
        else
        {

            list.Add(item, 1);
        }
    }

    public void DeleteItem(Item item)
    {
        if (list.ContainsKey(item))
        {
            if (list[item] >1)
            {
                list[item]--;
            } else
            {
                list.Remove(item);
            }
           
        }
        else
        {

            // TODO:  Error handling
        }
    }

    public Dictionary<Item, int> GetInventory()
    {
        return list;
    }

    public void PrintItems()
    {
        string printText = "";
        foreach (KeyValuePair<Item, int> kvp in list)
        {
            //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            printText += string.Format("Key = {0}, Value = {1}", kvp.Key.name, kvp.Value);
        }

        print(printText);
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
