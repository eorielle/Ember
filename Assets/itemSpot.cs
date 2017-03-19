using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpot : MonoBehaviour {

    private int itemCount = 1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void collectItem()
    {
        itemCount--;
        if (itemCount <= 0)
        {

        }
    }
}
