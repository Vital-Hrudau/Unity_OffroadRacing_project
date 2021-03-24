using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class garagebmw : MonoBehaviour {

    private int scoreInt, rubinInt;

    public void toMaps()
    {
        SceneManager.LoadScene(35);
    }
    public void backToClass()
    {
        SceneManager.LoadScene(33);
    }
    private void Start()
    {
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        rubinInt = PlayerPrefs.GetInt("rubin");
        scoreInt = PlayerPrefs.GetInt("score");
    }
    void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("rubin", rubinInt);
    }
}
