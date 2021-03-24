using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrontField : MonoBehaviour {

    public GameObject viborButton;
    public GameObject buyButton;
    public float timer;
    private int priceFront;
    private int scoreInt;
    private bool purchaseFront;

    void Start () {
        {
            if (!PlayerPrefs.HasKey("score"))
            {
                PlayerPrefs.SetInt("score", 0);
            }
            if (!PlayerPrefs.HasKey("buyFront"))
            {
                PlayerPrefs.SetInt("buyFront", 0);
            }
            scoreInt = PlayerPrefs.GetInt("score");
            priceFront = PlayerPrefs.GetInt("buyFront");
            timer = PlayerPrefs.GetFloat("timer");
            purchaseFront = false;
        }
    }
	
	
	void Update () {
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("buyFront", priceFront);
        priceFront = PlayerPrefs.GetInt("buyFront");
        PlayerPrefs.SetFloat("timer", timer);
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            timer = 0;
        }
        if (priceFront >= 1)
        {
            purchaseFront = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
        }
    }
    public void BuyFront()
    {
        if (scoreInt >= 850)
        {
            priceFront = 1;
            purchaseFront = true;
            print("Успешная покупка Frontera");
            viborButton.SetActive(true);
            buyButton.SetActive(false);
            scoreInt = scoreInt - 1200;
            PlayerPrefs.Save();
        }
        if (scoreInt < 850 )
        {
            print("Недостаточно средств");
        }
    }
    public void back()
    {
        SceneManager.LoadScene(1);
    }
    public void toUaz()
    {
        SceneManager.LoadScene(3);
    }
    public void toDef()
    {
        SceneManager.LoadScene(15);
    }
    public void togarage()
    {
        SceneManager.LoadScene(11);
    }
}
