using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbar : MonoBehaviour
{
    public float move_speed;

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
