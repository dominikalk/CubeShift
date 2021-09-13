using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Square" && GameManager.instance.gameover == false)
        {
            gameObject.SetActive(false);
            ScoreManager.instance.score += 1;
        }

        if (collision.gameObject.tag == "Remover")
        {
            Destroy(gameObject);
        }
    }
}
