using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour {
	public GameObject panelo;
	public float speed;
	public float speedRot;
	public GameObject player;
	private Collis collis;
	public Vector3 target;
	// Use this for initialization
	void Start () {
		collis = player.GetComponent<Collis> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (collis.play == false) {
			panelo.transform.position = Vector3.MoveTowards (panelo.transform.position, target, Time.deltaTime * speed);
			panelo.transform.Rotate (0, 0, Time.deltaTime * speedRot);
		}
	}
}
