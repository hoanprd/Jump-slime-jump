using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public float move_speed;
    float x;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        float move_step = move_speed * x * Time.deltaTime;
        transform.position = transform.position + new Vector3(move_step, 0 - Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Crossbar"))
        {
            transform.position = transform.position + new Vector3(0, Time.deltaTime * 70f, 0);
        }
        /*if (collision.gameObject.CompareTag("Rock"))
        {
            GameController.dead = true;
            Destroy(gameObject);
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadZone"))
        {
            GameController.dead = true;
            Destroy(gameObject);
        }
        if (collision.CompareTag("Rock"))
        {
            GameController.dead = true;
            Destroy(gameObject);
        }
        if (collision.CompareTag("Bird"))
        {
            GameController.dead = true;
            Destroy(gameObject);
        }
    }
}
