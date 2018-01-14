using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class igolkiScript : MonoBehaviour
{
    public float scrollSpeed;
	public Text text;
    public GameObject[] challenges;
	 

    float counter = 0.0f;
    public float goryCounter = 0.0f;
    public Transform challengesSpawn;
	public GameObject player;
	private Collis collis;
	public int score;



    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
		text = text.GetComponent<Text> ();
		collis = player.GetComponent<Collis> ();
		score = 0;

    }

    // Update is called once per frame
    void Update()
    {
		if (collis.play == true) {
			GameObject currentChild;

			if (counter <= 0.0f) {
				GenerateRandom ();
			} else {
				counter -= Time.deltaTime * Random.Range (0.5f, 0.7f);
			}



			for (int i = 0; i < transform.childCount; i++) {
				currentChild = transform.GetChild (i).gameObject;
				ChallengeScroller (currentChild);
				if (currentChild.transform.position.x <= -21.0f) {
					Destroy (currentChild);
					scrollSpeed = scrollSpeed + 0.3f;
					counter -= 0.5f;
					
                }
                if (currentChild.transform.position.x <= -12.0f && currentChild.transform.position.x >=-12.2f) {
                    score++;
                }
            }

            text.text = score.ToString();
           

		}
        if (score > PlayerPrefs.GetInt("MaxScore"))
        {
            PlayerPrefs.SetInt("MaxScore", score);
        }




    }
    void ChallengeScroller(GameObject currentChallenge)
    {
        currentChallenge.transform.position -= Vector3.right * (Time.deltaTime * scrollSpeed);

    }




    void GenerateRandom()
    {
        GameObject newChallenge = Instantiate(challenges[Random.Range(0, challenges.Length)], challengesSpawn.position, Quaternion.identity) as GameObject;
        newChallenge.transform.parent = transform;

        counter = 1.0f;
    }

   


}
