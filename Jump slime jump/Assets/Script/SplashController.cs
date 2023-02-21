using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashController : MonoBehaviour
{
    public float EndTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EndTime -= Time.deltaTime;

        if (EndTime <= 0)
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
