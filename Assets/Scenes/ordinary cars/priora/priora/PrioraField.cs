using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrioraField : MonoBehaviour {

    public GameObject viborButton;
    public GameObject buyButton;
    private int pricePriora;
    private int scoreInt;
    private bool purchaseDef;

    void Start()
    {
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        if (!PlayerPrefs.HasKey("buyPriora"))
        {
            PlayerPrefs.SetInt("buyPriora", 0);
        }
        scoreInt = PlayerPrefs.GetInt("score");
        pricePriora = PlayerPrefs.GetInt("buyPriora");
        purchaseDef = false;
        pricePriora = 1;
    }


    void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("buyPriora", pricePriora);
        pricePriora = PlayerPrefs.GetInt("buyPriora");
        if (pricePriora >= 1)
        {
            //purchaseDef = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
        }
    }
    public void BuyPriora()
    {
        if (scoreInt >= 750)
        {
            pricePriora = 1;
            purchaseDef = true;
            print("Успешная покупка Priora");
            viborButton.SetActive(true);
            buyButton.SetActive(false);
            scoreInt = scoreInt - 750;
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
    public void toAscona()
    {
        SceneManager.LoadScene(23);
    }
    public void togarage()
    {
        SceneManager.LoadScene(20);
    }
}
