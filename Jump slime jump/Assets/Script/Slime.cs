using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public Animator SlimeAni;
    public AudioSource SlimeJumpSound;

    public float move_speed;
    float x;
    bool moveL, moveR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveL == true)
        {
            x = -1;
        }
        else if (moveR == true)
        {
            x = 1;
        }
        else
        {
            x = 0;
        }

        x = Input.GetAxisRaw("Horizontal");
        float move_step = move_speed * x * Time.deltaTime;
        transform.position = transform.position + new Vector3(move_step, -Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Crossbar"))
        {
            SlimeJumpSound.Play();
            SlimeAni.SetTrigger("ChangeShape");
            transform.position = transform.position + new Vector3(0, Time.deltaTime * 70f, 0);
        }
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

    public void MovementL(bool _move)
    {
        moveL = _move;
    }

    public void MovementR(bool _move)
    {
        moveR = _move;
    }
}
