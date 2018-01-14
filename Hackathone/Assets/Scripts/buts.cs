using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buts : MonoBehaviour {
    private LevelOne levelOne;
    public GameObject sun;
    public Text text;
    public int counter;
	// Use this for initialization
	void Start () {
        levelOne = sun.GetComponent<LevelOne>();
        counter = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "pojar":
                if (levelOne.rand == 0)
                {
                    counter++;
                    PlayerPrefs.SetInt("score", counter);
                   
                    SceneManager.LoadScene("1level");
                    
                    
                }
                else
                {
                    SceneManager.LoadScene("lostPlay");
                }
                break;
            case "milic":
                if (levelOne.rand == 1)
                {
                    counter++;
                    PlayerPrefs.SetInt("score", counter);
                    
                    SceneManager.LoadScene("1level");
                    
                }
                else
                {
                    SceneManager.LoadScene("lostPlay");
                }
                break;
            case "scoraya":
                if (levelOne.rand == 2)
                {
                    counter++;
                    PlayerPrefs.SetInt("score", counter);
                   
                    SceneManager.LoadScene("1level");
                    
                }
                else
                {
                    SceneManager.LoadScene("lostPlay");
                }
                break;
            case "gas":
                if (levelOne.rand == 3)
                {
                    counter++;
                    PlayerPrefs.SetInt("score", counter);
                   
                    SceneManager.LoadScene("1level");
                    
                }
                else
                {
                    SceneManager.LoadScene("lostPlay");
                }
                break;


        }

    }
    
}
