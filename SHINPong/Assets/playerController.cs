using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * 11f * Time.deltaTime);
        var pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
