using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class garage2107 : MonoBehaviour {

    private int scoreInt, rubinInt;

    public void toMaps()
    {
        SceneManager.LoadScene(39);
    }
    public void backToClass()
    {
        SceneManager.LoadScene(37);
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
