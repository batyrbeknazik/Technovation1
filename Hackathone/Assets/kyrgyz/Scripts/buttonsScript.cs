using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonsScript : MonoBehaviour {


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
            case "insta":
                Application.OpenURL("https://www.instagram.com/CodeGeneration/");
                break;
            case "face":
                Application.OpenURL("https://www.facebook.com/codegeneration.kg/?fref=ts");
                break;
            case "vk":
                Application.OpenURL("https://vk.com/codegeneration");
                break;
			case "replay":
                SceneManager.LoadScene("Playone");
                break;
			case "back":
                SceneManager.LoadScene("Game");
                break;
            
                



        }
        
    }
    public void Change() {
        SceneManager.LoadScene("Main");
    }
}
