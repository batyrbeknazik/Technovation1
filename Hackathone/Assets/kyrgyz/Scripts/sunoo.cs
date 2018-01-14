using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunoo : MonoBehaviour {
    public GameObject sun;
    public GameObject player;
    public float speed;
    private Collis collis;
    public bool play;
	// Use this for initialization
	void Start () {
        collis = player.GetComponent<Collis>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        play = collis.play;
        if(play == true) {
            sun.transform.Rotate(0, 0, Time.deltaTime * speed);

        }



    }
}
