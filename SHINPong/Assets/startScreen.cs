﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartButtonPressed()
    {
        SceneManager.LoadScene("level1");
    }
    public void QuitButtonPressed()
    {
        Application.Quit();
    }

}
