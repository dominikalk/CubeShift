using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour {

    Rigidbody2D rb;
    bool gameover;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        gameover = false;
    }
	
	// Update is called once per frame
	void Update () {
        gameover = GameManager.instance.gameover;
        if (Input.GetMouseButtonDown(0) && !gameover)
        {
            rb.gravityScale = -rb.gravityScale;
        }

        if (GameManager.instance.gameover == true)
        {
            rb.gravityScale = 3;

        }
	}
}
