using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer += Time.deltaTime;

        if (Random.Range(0, 100) < 5)
        {
            coin = Pool.Instance.Get("Coin");
            if (coin != null)
            {
                if (timer > 2.0f)
                {
                     coin.transform.position = this.transform.position + new Vector3(Random.Range(-200f, 200f), Random.Range(9f,11f), 0); 
                    coin.SetActive(true);

                }

            }
           
        }
    }
}