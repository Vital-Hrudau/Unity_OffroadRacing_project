using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YTubeScore : MonoBehaviour {

    private int scoreInt;
    public float timer = 60;
    public Text timetext;
    private bool ad;
	
	void Start () {
        if (!PlayerPrefs.HasKey("timer"))
        {
            PlayerPrefs.SetFloat("timer", 60);
        }
        scoreInt = PlayerPrefs.GetInt("score");
        timer = PlayerPrefs.GetFloat("timer");
        ad = false;
    }
	
	void Update () {
        PlayerPrefs.SetInt("score", scoreInt);
        PlayerPrefs.SetFloat("timer", timer);
        timetext.text = timer.ToString();
        if (ad == false)
        {
            timer = timer - Time.deltaTime;
        }

        if (timer <= 0 )
        {
            ad = true;
            timer = 0;
            timetext.text = ("Забирай бонус!");
           
        }
    }
    public void YTubeAd()
    {
        if(timer <= 0 || ad == true)
        {
            timer = 60;
            scoreInt = PlayerPrefs.GetInt("score");
            //showAdVideo
            ad = false;
            scoreInt += 100;
            PlayerPrefs.Save();
        }
       
    }
}
