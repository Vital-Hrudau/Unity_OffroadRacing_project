using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefField : MonoBehaviour {

    public GameObject viborButton;
    public GameObject buyButton;
    private int priceDef;
    private int scoreInt;
    private bool purchaseDef;
    public float timer;

    void Start () {
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        if (!PlayerPrefs.HasKey("buyDef"))
        {
            PlayerPrefs.SetInt("buyDef", 0);
        }
        scoreInt = PlayerPrefs.GetInt("score");
        priceDef = PlayerPrefs.GetInt("buyDef");
        timer = PlayerPrefs.GetFloat("timer");
        purchaseDef = false;
    }
	
	
	void Update () {
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("buyDef", priceDef);
        priceDef = PlayerPrefs.GetInt("buyDef");
        PlayerPrefs.SetFloat("timer", timer);
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            timer = 0;
        }
        if (priceDef >= 1)
        {
            purchaseDef = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
        }
    }
    public void BuyDef()
    {
        if (scoreInt >= 1200)
        {
            priceDef = 1;
            purchaseDef = true;
            print("Успешная покупка Defender");
            viborButton.SetActive(true);
            buyButton.SetActive(false);
            scoreInt = scoreInt - 1200;
            PlayerPrefs.Save();
        }
        if (scoreInt < 1200)
        {
            print("Недостаточно средств");
        }
    }
    public void back()
    {
        SceneManager.LoadScene(1);
    }
    public void toFront()
    {
        SceneManager.LoadScene(10);
    }
    public void togarage()
    {
        SceneManager.LoadScene(16);
    }
}
