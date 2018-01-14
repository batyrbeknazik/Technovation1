using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttonPlay : MonoBehaviour {
    public GameObject player;
    public float jumpPower = 10.0f;
    Rigidbody myRigidbody;
	// Use this for initialization
	void Start () {
		

    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OnMouseDown()
    {
        player.transform.Translate(0, 0, 1);
    }
}
