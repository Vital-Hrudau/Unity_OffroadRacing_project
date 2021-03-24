using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour {

    public int scoreInt, rubinInt;
    public Text score;

    void Start () {
        scoreInt = PlayerPrefs.GetInt("score");
        rubinInt = PlayerPrefs.GetInt("rubin");
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        if (!PlayerPrefs.HasKey("rubin"))
        {
            PlayerPrefs.SetInt("rubin", 0);
        }
        score.text = scoreInt.ToString();
    }

    void Update () {
        PlayerPrefs.SetInt("score", scoreInt);
        PlayerPrefs.SetInt("rubin", rubinInt);
        score.text = scoreInt.ToString();
    }
}
