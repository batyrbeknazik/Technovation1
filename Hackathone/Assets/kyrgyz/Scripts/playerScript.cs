using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public GameObject player;
    
    public float jumpPower = 10.0f;
    Rigidbody2D myRigidbody;
    private Collis collis;
    public bool zamlyaTwo;


    // Use this for initialization
    private void Awake()
    {
        collis = player.GetComponent<Collis>();
    }
    void Start()
    {
        player.GetComponent<Rigidbody2D>();
       

    }

    // Update is called once per frame

    void OnMouseDown()
    {

        if (collis.zemlya == true)
        {
            player.GetComponent<Rigidbody2D>().AddForce(player.transform.up * jumpPower);
            
        }
       


    }




}

