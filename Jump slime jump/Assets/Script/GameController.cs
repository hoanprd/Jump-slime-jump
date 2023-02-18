using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;

    public static bool dead;
    public float EndTime;

    // Start is called before the first frame update
    void Start()
    {
        dead = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dead == true)
        {
            GameOverPanel.SetActive(true);

            EndTime -= Time.deltaTime;
        }

        if (EndTime <= 0)
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
