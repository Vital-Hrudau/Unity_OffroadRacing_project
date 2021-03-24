using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bmwfield : MonoBehaviour {

    public GameObject viborButton;
    public GameObject buyButton;
    public int priceBmw;
    private int scoreInt;
    private bool purchaseDef;

    void Start()
    {
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        if (!PlayerPrefs.HasKey("buyBmw"))
        {
            PlayerPrefs.SetInt("buyBmw", 0);
        }
        scoreInt = PlayerPrefs.GetInt("score");
        priceBmw = PlayerPrefs.GetInt("buyBmw");
        //purchaseDef = false;
    }


    void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("buyBmw", priceBmw);
        priceBmw = PlayerPrefs.GetInt("buyBmw");
        if (priceBmw >= 1)
        {
            purchaseDef = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
        }
        if (priceBmw == 0)
        {
            purchaseDef = false;
            viborButton.SetActive(false);
            buyButton.SetActive(true);
        }

    }
    public void BuyBmw()
    {
        if (scoreInt >= 1800)
        {
            priceBmw = 1;
            purchaseDef = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
            scoreInt = scoreInt - 1800;
            PlayerPrefs.Save();
        }
        if (scoreInt < 1800)
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
        SceneManager.LoadScene(37);
    }
    public void togarage()
    {
        SceneManager.LoadScene(34);
    }
    public void toAscona()
    {
        SceneManager.LoadScene(23);
    }
}
