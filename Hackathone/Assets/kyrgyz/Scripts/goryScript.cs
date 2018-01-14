using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goryScript : MonoBehaviour
{
    public float scrollSpeed;

    public GameObject[] challenges;

    public float frequency = 0.5f;
    float counter = 1.0f;
    public float goryCounter = 0.0f;
    public Transform challengesSpawn;
    public GameObject derevya;
	public GameObject player;
	private Collis collis;




    // Use this for initialization
    void Start()
    {
        GenerateRandom();
		collis = player.GetComponent<Collis> ();


    }

    // Update is called once per frame
    void Update()
    {
		
		if(collis.play==true){
        GameObject currentChild;

        if (counter <= 0.0f)
        {
            GenerateRandom();
        }

        else
        {
            counter -= Time.deltaTime * 0.06f;
        }



        for (int i = 0; i < transform.childCount; i++)
        {
            currentChild = transform.GetChild(i).gameObject;
            ChallengeScroller(currentChild);
            if (currentChild.transform.position.x <= -23.0f)
            {
                Destroy(currentChild);
            }
        }





        ChallengeScroller(derevya);
        if (derevya.transform.position.x <= -21.0f)
        {
            derevya.SetActive(false);
        }


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
