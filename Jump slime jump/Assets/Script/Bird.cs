using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float move_speed;

    // Update is called once per frame
    void Update()
    {
        float move_step = move_speed * Time.deltaTime;

        transform.position = transform.position + new Vector3(-move_step, 0, 0);

        if (transform.position.x <= -15)
        {
            Destroy(gameObject);
        }
    }
}
