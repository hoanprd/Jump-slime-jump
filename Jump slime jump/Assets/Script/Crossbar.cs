using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbar : MonoBehaviour
{
    public GameObject Coin;
    public int CoinRand;
    public float move_speed;

    void Start()
    {
        CoinRand = Random.Range(1, 11);

        if (CoinRand == 1 || CoinRand == 2 || CoinRand == 3 || CoinRand == 4)
        {
            Coin.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float move_step = move_speed * Time.deltaTime;

        transform.position = transform.position + new Vector3(0, move_step, 0);

        if (GameController.dead == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DestroyZone"))
        {
            Destroy(gameObject);
        }
    }
}
