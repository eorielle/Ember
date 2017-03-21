using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpot : Interactable {

    public int itemCount;
    private Item item;

    public override void Interact()
    {
        // Collect 
        itemCount--;
        FindObjectOfType<Player>().inventory.AddItem(item);
        Debug.Log(itemCount);

        if (itemCount <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        item = new Item("tesSpotItem", "this is a test for item spots");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        interactable = true;
        print("Interactable !! ");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        interactable = false;
        print("Not Interactable !! ");
    }

}
