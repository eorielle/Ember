﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;

    private static bool cameraExists;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
        
        if (cameraExists)
        {
            Destroy(transform.gameObject);
        }
        else
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
