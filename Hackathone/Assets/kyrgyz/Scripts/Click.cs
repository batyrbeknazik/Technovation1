using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {
   public GameObject player;
    public GameObject click;
    private Collis collis;
	// Use this for initialization
	void Start () {
        collis = player.GetComponent<Collis>();
	}
	
	// Update is called once per frame
	void Update () {
        if (collis.play == false) {
            click.SetActive(false);
        }
	}
}
