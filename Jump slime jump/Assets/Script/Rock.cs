using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public float move_speed;

    // Update is called once per frame
    void Update()
    {
        float move_step = move_speed * Time.deltaTime;

        transform.position = transform.position + new Vector3(0, -move_step, 0);

        if (transform.position.y <= -8)
        {
            Destroy(gameObject);
        }
    }
}
