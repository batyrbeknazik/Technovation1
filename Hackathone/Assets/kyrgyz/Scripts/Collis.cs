using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collis : MonoBehaviour {
    public bool zemlya;
    public bool play = true;
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (player.transform.position.x < -10.0f || player.transform.position.x > 10.0f || player.transform.position.y < -5.0f || player.transform.position.y > 7.0f) {
            play = false;
        }
	}
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "zemlya") {
            zemlya = true;
           
        }
        if (other.collider.tag == "barier") {
            play = false;
        }
    }
   
    public void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "zemlya")
        {
            zemlya = true;
           
        }
        if (other.collider.tag=="barier") {
            play = false;
        }
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "zemlya") {
            zemlya = false;
    
           
        }
        
    }
}
