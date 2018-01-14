using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour
{
    public float scrollSpeed = 0.1f;
    public GameObject player;
    public GameObject[] challenges;
    
    public float frequency = 0.5f;
    float counter = 0.0f;
    public float goryCounter = 0.0f;
    public Transform challengesSpawn;
    public GameObject derevya;
    private Collis collis;
    public bool play;

   
    // Use this for initialization
    void Start()
    {

        collis = player.GetComponent<Collis>();
       
    }

    // Update is called once per frame
    void Update()
    {
        play = collis.play;
        if (play == true)
        {
            GameObject currentChild;

            if (counter <= 0.0f)
            {
                GenerateRandom();
            }

            else
            {
                counter -= Time.deltaTime * 0.3f;
            }



            for (int i = 0; i < transform.childCount; i++)
            {
                currentChild = transform.GetChild(i).gameObject;
                ChallengeScroller(currentChild);
                if (currentChild.transform.position.x <= -21.0f)
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
        play = collis.play;

        if (play == true) {
            currentChallenge.transform.position -= Vector3.right * (Time.deltaTime * scrollSpeed);

        }

    }
   



    void GenerateRandom()
    {
        GameObject newChallenge = Instantiate(challenges[Random.Range(0, challenges.Length)], challengesSpawn.position, Quaternion.identity) as GameObject;
        newChallenge.transform.parent = transform;

        counter = 1.0f;
    }
 



}

