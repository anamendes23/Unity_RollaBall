using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //public variables can be change in the editor
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = string.Empty;
    }
    private void Update() //called before rendering a frame
    {
        
    }

    private void FixedUpdate() //called before performing any physics calculation
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //input from user
        float moveVertical = Input.GetAxis("Vertical"); //input from user

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        //if (other.gameObject.CompareTag("Player"))
        //    gameObject.SetActive(false);
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    //function
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 12)
        { winText.text = "You win!"; }
    }
}
