using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour {

    public abstract void Interact();
    protected bool interactable = false;


    void Update()
    {
        if (Input.GetButtonUp("Interact") && interactable)
        {
            Interact();
            Debug.Log("Not Trigger");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().isTrigger)
        {
            Interact();
            Debug.Log("Trigger");
        }
        
    }

}
