﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class loser : MonoBehaviour {
	// Use this for initialization
	void Start () {
        
        GetComponent<Text>().text = PlayerPrefs.GetInt("MaxScore").ToString();
        
    }
    void Update()
    {
        

    }



}
