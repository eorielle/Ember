using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    private Player player;
    private Camera camera;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<Player>();
        player.transform.position = transform.position;

        camera = FindObjectOfType<Camera>();
        camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
