using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Text scoreText;
    public int scoreInt;
  


    void Start () {
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        scoreText.text = scoreInt.ToString();
        scoreInt = PlayerPrefs.GetInt("score");
    }
	
	
	void Update ()
    {
        scoreText.text = scoreInt.ToString();
        scoreInt = PlayerPrefs.GetInt("score");
    }
}
