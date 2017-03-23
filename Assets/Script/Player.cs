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


    private Rigidbody2D body;

    private float speed = 0.1f;

    public Inventory inventory;

    public int velocity;

    private static bool playerExists;


    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();

        animator.SetFloat("inputX", 0);
        animator.SetFloat("inputY", -1);
        animator.SetBool("isWalking", false);

        inventory = new Inventory();

        // Inventory test
        inventory.AddItem(new Item("testItem", "This is an item for test"));
        inventory.PrintItems();

        if(playerExists)
        {
            Destroy(transform.gameObject);
        } else
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }

       
    }
	
	// Update is called once per frame
	void Update () {

       
        // handle character animation
        Vector2 moveVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (moveVector != Vector2.zero)
        {
            animator.SetBool("isWalking", true);
            animator.SetFloat("inputX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("inputY", Input.GetAxisRaw("Vertical"));

            
        } else
        {
            animator.SetBool("isWalking", false);
        }

        // Handle character movement
        body.MovePosition(body.position + moveVector * Time.deltaTime * velocity);

    }
}
