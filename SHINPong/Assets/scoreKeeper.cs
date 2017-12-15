using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeper : MonoBehaviour {

    public int Truep1Score, Truep2Score;
    // Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
