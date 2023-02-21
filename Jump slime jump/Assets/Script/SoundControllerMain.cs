using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControllerMain : MonoBehaviour
{
    public AudioSource[] BGMSound;
    public AudioSource[] FXSound;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < BGMSound.Length; i++)
        {
            BGMSound[i].volume = PlayerPrefs.GetFloat("SBGM");
        }

        for (int i = 0; i < FXSound.Length; i++)
        {
            FXSound[i].volume = PlayerPrefs.GetFloat("SFX");
        }
    }
}
