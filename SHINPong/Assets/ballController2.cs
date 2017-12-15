using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballController2 : MonoBehaviour {
    // Use this for initialization
    GameObject p1Goal,p2Goal;
    public int p1Score,p2Score;
    Text p1Text, p2Text, totalP1Text, totalP2Text;
    scoreKeeper ScoreKeeper;
    void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-14f,0);
        p1Goal = GameObject.Find("P1Goal");
        p2Goal = GameObject.Find("P2Goal");
        p1Text = GameObject.Find("P1 Score").GetComponent<Text>();
        totalP1Text = GameObject.Find("Total P1 Score").GetComponent<Text>();
        p2Text = GameObject.Find("P2 Score").GetComponent<Text>();
        totalP2Text = GameObject.Find("Total P2 Score").GetComponent<Text>();
        ScoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<scoreKeeper>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        float randomX = Random.Range(-2f, 2f);
        GetComponent<Rigidbody2D>().velocity += new Vector2(0, randomX);
        if (collision.gameObject == p1Goal)
        {
            transform.position = new Vector3(0,0, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(14f, 0);
            ScoreKeeper.Truep2Score += 2;
            p2Score += 2;
        }
        else if (collision.gameObject == p2Goal)
        {
            transform.position = new Vector3(0, 0, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-14f, 0);
            ScoreKeeper.Truep1Score += 2;
            p1Score += 2;
        }

    }
    // Update is called once per frame
    void Update () {
        p1Text.text = p1Score.ToString();
        p2Text.text = p2Score.ToString();
        totalP1Text.text =  ScoreKeeper.Truep1Score.ToString();
        totalP2Text.text = ScoreKeeper.Truep2Score.ToString();
        if (p1Score == 10 || p2Score == 10)
        {
            
            SceneManager.LoadScene("level3");



        }
    }
   

}
