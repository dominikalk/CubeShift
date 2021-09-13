using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]


public class TriangleController : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    bool moved;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.instance.started == true && moved == false)
        {
            move();
            moved = true;
        }
    }

    void move()
    {
        rb.AddForce(new Vector2(speed, 0));
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Remover")
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Square")
        {
            GameManager.instance.gameover = true;
        }
    }




}
