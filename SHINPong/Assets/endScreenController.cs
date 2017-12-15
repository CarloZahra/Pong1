using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScreenController : MonoBehaviour {
    Text p1FinalText,p2FinalText,wonResult;
    scoreKeeper ScoreKeeper;
    // Use this for initialization
    void Start () {
        p1FinalText = GameObject.Find("P1 Final Score").GetComponent<Text>();
        p2FinalText = GameObject.Find("P2 Final Score").GetComponent<Text>();
        wonResult = GameObject.Find("Won").GetComponent<Text>();
        ScoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<scoreKeeper>();
        p1FinalText.text += ScoreKeeper.Truep1Score.ToString();
        p2FinalText.text += ScoreKeeper.Truep2Score.ToString();
        if (ScoreKeeper.Truep1Score > ScoreKeeper.Truep2Score)
        {
            wonResult.text = "Player 1 is the winner";
        }
        else if (ScoreKeeper.Truep2Score > ScoreKeeper.Truep1Score)
        {
            wonResult.text = "Player 2 is the winner";
        }
        else if (ScoreKeeper.Truep1Score > ScoreKeeper.Truep2Score)
        {
            wonResult.text = "Draw";
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
