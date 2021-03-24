using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class asconaField : MonoBehaviour {

    public GameObject viborButton;
    public GameObject buyButton;
    private int priceAscona;
    private int scoreInt;
    private bool purchaseDef;

    void Start()
    {
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        if (!PlayerPrefs.HasKey("buyAscona"))
        {
            PlayerPrefs.SetInt("buyAscona", 0);
        }
        scoreInt = PlayerPrefs.GetInt("score");
        priceAscona = PlayerPrefs.GetInt("buyAscona");
        purchaseDef = false;
    }


    void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("buyAscona", priceAscona);
        priceAscona = PlayerPrefs.GetInt("buyAscona");
        if (priceAscona >= 1)
        {
            purchaseDef = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
        }
    }
    public void BuyAscona()
    {
        if (scoreInt >= 1025)
        {
            priceAscona = 1;
            purchaseDef = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
            scoreInt = scoreInt - 1025;
            PlayerPrefs.Save();
        }
        if (scoreInt < 1025)
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
        SceneManager.LoadScene(23);
    }
    public void togarage()
    {
        SceneManager.LoadScene(24);
    }
    public void toPriora()
    {
        SceneManager.LoadScene(18);
    }
    public void tobmw()
    {
        SceneManager.LoadScene(33);
    }
}
