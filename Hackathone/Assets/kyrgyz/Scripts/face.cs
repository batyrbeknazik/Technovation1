using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class face : MonoBehaviour {
	public GameObject faceo;
	public GameObject player;
	private Collis collis;
	// Use this for initialization
	void Start () {
		collis = player.GetComponent<Collis> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (collis.play == false) {
			faceo.SetActive (true);
		}
	}
}
