using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour {
	public GameObject buttonso;
	private Collis collis;
	public GameObject player;
	public bool play;
	public Vector3 target;
	public float speed;
	// Use this for initialization
	void Start () {
		collis = player.GetComponent<Collis> ();
	}
	
	// Update is called once per frame
	void Update () {
		play = collis.play;
		if (play == false) {
			buttonso.transform.position = Vector3.MoveTowards (buttonso.transform.position, target, Time.deltaTime * speed);
		}
	}
}
