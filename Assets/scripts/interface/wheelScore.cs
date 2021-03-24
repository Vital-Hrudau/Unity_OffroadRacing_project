using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelScore : MonoBehaviour
{

    public int scoreInt;
    private int rubinInt;

    void Start()
    {
        //if (!PlayerPrefs.HasKey("score"))
        {
           // PlayerPrefs.SetInt("score", 0);
        }
        scoreInt = PlayerPrefs.GetInt("score");
        rubinInt = PlayerPrefs.GetInt("rubin");
       
    }

    void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        PlayerPrefs.SetInt("rubin", rubinInt);
        scoreInt = PlayerPrefs.GetInt("score");
        rubinInt = PlayerPrefs.GetInt("rubin");

    }
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "coins")
        {
            scoreInt = PlayerPrefs.GetInt("score");
            scoreInt++;
            //scoreInt = scoreInt + 1;
            //Destroy(trigger.gameObject);
        }
            if (trigger.gameObject.tag == "rubin")
        {
            rubinInt = PlayerPrefs.GetInt("rubin");
            rubinInt = rubinInt + 1;
            //Destroy(trigger.gameObject);
        }
    }
}
