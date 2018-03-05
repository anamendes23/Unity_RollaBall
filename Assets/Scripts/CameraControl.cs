using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}
    //garantees that the player moved before the camera
    private void LateUpdate() //run after all process have been processed in update
    {
        transform.position = player.transform.position + offset;
    }
}
