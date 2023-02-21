using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Text HighScoreText;
    public GameObject SettingPanel;

    public static int HighScore;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("SHighScore"))
        {
            PlayerPrefs.SetInt("SHighScore", 0);
            HighScore = PlayerPrefs.GetInt("SHighScore");
        }
        else
        {
            HighScore = PlayerPrefs.GetInt("SHighScore");
        }

        HighScoreText.text = "High score: " + HighScore;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayButton()
    {
        ScoreController.Score = 0;

        SceneManager.LoadScene("MainScene");
    }

    public void OpenSettingPanel()
    {
        SettingPanel.SetActive(true);
    }

    public void CloseSettingPanel()
    {
        SettingPanel.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
