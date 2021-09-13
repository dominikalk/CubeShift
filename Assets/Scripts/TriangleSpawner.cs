using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSpawner : MonoBehaviour {

    public float SpawnTime;
    public GameObject Triangle;
    public GameObject TriangleBottom;
    public GameObject Coin;
    float TopBottom;
    float YesNo;
    float CoinYesNo;
    bool spawned;

    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.started == true)
        {
            StartSpawningTri();
        }
        if (GameManager.instance.gameover == true)
        {
            StopSpawningTri();
        }
    }

    public void StopSpawningTri()
    {
        CancelInvoke("SpawnTri");
    }

    public void StartSpawningTri()
    {
        if (spawned == false)
        {
            InvokeRepeating("SpawnTri", 0.2f, SpawnTime);
            spawned = true;
        }
    }

    void SpawnTri()
    {
        TopBottom = Random.Range(0, 2);
        if(TopBottom == 0)
        {
            YesNo = Random.Range(0, 2);
            if (YesNo == 0)
            {
                Instantiate(Triangle, new Vector3(transform.position.x, 3.69f, 0), Quaternion.identity);
            }
            else
            {
                CoinYesNo = Random.Range(0, 2);
                if (CoinYesNo == 0)
                {
                    Instantiate(Coin, new Vector3(transform.position.x, 3.69f, 0), Quaternion.identity);

                }
            }
        }
        else
        {
            YesNo = Random.Range(0, 2);
            if (YesNo == 0)
            {
                Instantiate(TriangleBottom, new Vector3(transform.position.x, -3.69f, 0), Quaternion.Euler(new Vector2(180f,0f)));
            }
            else
            {
                CoinYesNo = Random.Range(0, 2);
                if (CoinYesNo == 0)
                {
                    Instantiate(Coin, new Vector3(transform.position.x,-3.69f, 0), Quaternion.identity);

                }
            }
        }

    }
}
