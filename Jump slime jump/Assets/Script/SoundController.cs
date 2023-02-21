using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public Slider BGMSlider, FXSlider;
    public AudioSource[] BGMSound;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("SBGM"))
        {
            BGMSlider.value = 0.5f;
        }
        else
        {
            BGMSlider.value = PlayerPrefs.GetFloat("SBGM");
        }

        if (!PlayerPrefs.HasKey("SFX"))
        {
            FXSlider.value = 0.5f;
        }
        else
        {
            FXSlider.value = PlayerPrefs.GetFloat("SFX");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeValueBGM()
    {
        for (int i = 0; i < BGMSound.Length; i++)
        {
            BGMSound[i].volume = BGMSlider.value;
        }

        PlayerPrefs.SetFloat("SBGM", BGMSlider.value);
    }

    public void ChangeValueFX()
    {
        PlayerPrefs.SetFloat("SFX", FXSlider.value);
    }
}
