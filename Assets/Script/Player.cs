using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Animator animator; 
    private int DIRECTION_IDLE = 0;
    private int DIRECTION_LEFT = 1;
    private int DIRECTION_RIGHT = 2;
    private int DIRECTION_FRONT = 3;
    private int DIRECTION_BACK = 4;


    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Up"))
        {
            animator.SetInteger("DirectionState", DIRECTION_BACK);
        }
        else if (Input.GetButton("Down"))
        {
            animator.SetInteger("DirectionState", DIRECTION_FRONT);
        }
        else if (Input.GetButton("Left"))
        {
            animator.SetInteger("DirectionState", DIRECTION_LEFT);
        }
        else if (Input.GetButton("Right"))
        {
            animator.SetInteger("DirectionState", DIRECTION_RIGHT);
        } else
        {
            animator.SetInteger("DirectionState", DIRECTION_IDLE);
        }

    }
}
