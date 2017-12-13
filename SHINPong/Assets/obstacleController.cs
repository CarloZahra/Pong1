using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleController : MonoBehaviour {

    GameObject topWall, bottomWall;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3f);
        topWall= GameObject.Find("Top Wall");
        bottomWall = GameObject.Find("Bottom Wall");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == bottomWall)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 3f);
        }
        else if (collision.gameObject == topWall)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -3f);
        }
    }
        // Update is called once per frame
        void Update () {

        }
}
