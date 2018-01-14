using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        switch (gameObject.name) {
            case "play":
                SceneManager.LoadScene("Play");
                break;
            case "facebook":
                Application.OpenURL("https://www.facebook.com/codegeneration.kg/?fref=ts");
                break;
            case "back":
                SceneManager.LoadScene("Game");
                break;
            case "2level":
                SceneManager.LoadScene("2level");
                break;
            case "3level":
                SceneManager.LoadScene("Playone");
                break;
            
            
        }

    }
    public void ChangeScene() {
        SceneManager.LoadScene("1level");
    }
}
