using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ballController : MonoBehaviour {
    // Use this for initialization
    GameObject p1Goal,p2Goal;
    public int p1Score,p2Score;
    Text p1Text, p2Text;
    scoreKeeper ScoreKeeper;
    void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-10f,0);
        p1Goal = GameObject.Find("P1Goal");
        p2Goal = GameObject.Find("P2Goal");
        p1Text= GameObject.Find("P1 Score").GetComponent<Text>();
        p2Text = GameObject.Find("P2 Score").GetComponent<Text>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float randomX = Random.Range(-2f, 2f);
        GetComponent<Rigidbody2D>().velocity += new Vector2(0, randomX);
        if (collision.gameObject == p1Goal)
        {
            transform.position = new Vector3(0,0, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0);
            p2Score = p2Score+1;
        }
        else if (collision.gameObject == p2Goal)
        {
            transform.position = new Vector3(0, 0, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0);
            p1Score =p1Score +1;
        }

    }
    // Update is called once per frame
    void Update () {
        p1Text.text = p1Score.ToString();
        p2Text.text = p2Score.ToString();
        if (p1Score == 5 || p2Score == 5)
        {
            SceneManager.LoadScene("level2");
            ScoreKeeper.Truep1Score+=p1Score;
            ScoreKeeper.Truep2Score+=p2Score;
            
            
        }    
    }
   

}
