using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public GameObject player;
    
    public float jumpPower = 10.0f;
    Rigidbody2D myRigidbody;


    // Use this for initialization
    void Start()
    {
        myRigidbody = player.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

    void OnMouseDown()
    {
        

                myRigidbody.AddForce(Vector2.up * (jumpPower * myRigidbody.mass * myRigidbody.gravityScale * 50.0f));
            
        
    }




}
