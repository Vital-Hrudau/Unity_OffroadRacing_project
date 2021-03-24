using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uazField : MonoBehaviour {

    public GameObject viborButton;
    public GameObject buyButton;
    private int priceUaz;
    private int scoreInt;
    private bool purchaseUaz;
    public float timer;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        if (!PlayerPrefs.HasKey("buyUaz"))
        {
            PlayerPrefs.SetInt("buyUaz", 0);
        }
        scoreInt = PlayerPrefs.GetInt("score");
        priceUaz = PlayerPrefs.GetInt("buyUaz");
        timer = PlayerPrefs.GetFloat("timer");
        purchaseUaz = false;
    }
    private void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("buyUaz", priceUaz);
        priceUaz = PlayerPrefs.GetInt("buyUaz");
        PlayerPrefs.SetFloat("timer", timer);
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            timer = 0;
        }

        if (priceUaz >= 1)
        {
            purchaseUaz = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
        }
    }
    public void BuyUaz()
    {
        if (scoreInt >= 350) 
        {
            priceUaz = 1;
            purchaseUaz = true;
            print("Успешная покупка Уаза");
            viborButton.SetActive(true);
            buyButton.SetActive(false);
            scoreInt = scoreInt - 350;
            PlayerPrefs.Save();
            
        }
        if (scoreInt < 350)
        {
            print("Недостаточно средств");
        }
    }


    public void back()
    {
        SceneManager.LoadScene(1);
    }
    public void toNiva()
    {
        SceneManager.LoadScene(2);
    }
    public void togarage()
    {
        SceneManager.LoadScene(7);
    }
    public void next()
    {
        SceneManager.LoadScene(10);
    }
}
