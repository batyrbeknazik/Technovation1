using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelOne : MonoBehaviour {
    public int rand;
    public GameObject[] quest;

    // Use this for initialization
    void Start () {
        rand = Random.Range(0, quest.Length);
        Instantiate(quest[rand], quest[rand].transform.position, Quaternion.identity);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
}
