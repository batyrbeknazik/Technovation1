using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float scrollSpeed = 10.0f;
    public GameObject[] challenges;
    public float frequency = 0.5f;
    public int spawno;
    float counter = 0.0f;
    public Transform challengesSpawn;

    // Use this for initialization
    void Start()
    {
        GenerateRandom();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject currentChild;

        if (counter <= 0.0f)
        {
            GenerateRandom();
        }

        else
        {
            counter -= Time.deltaTime * Random.Range(0.5f, 1.0f);
        }


        for (int i = 0; i < transform.childCount; i++)
        {
            currentChild = transform.GetChild(i).gameObject;
            ChallengeScroller(currentChild);
            if (currentChild.transform.position.x >= spawno)
            {
                Destroy(currentChild);
            }
        }



    }
    void ChallengeScroller(GameObject currentChallenge)
    {
        currentChallenge.transform.position = Vector3.right * (Time.deltaTime * scrollSpeed);

    }


    void GenerateRandom()
    {
        GameObject newChallenge = Instantiate(challenges[Random.Range(0, challenges.Length)], challengesSpawn.position, challenges[0].transform.rotation) as GameObject;
        newChallenge.transform.parent = transform;

        counter = 1.0f;
    }


}
