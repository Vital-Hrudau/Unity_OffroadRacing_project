using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vazfield : MonoBehaviour {

    public GameObject viborButton;
    public GameObject buyButton;
    public int pricevaz;
    public int scoreInt, rubinInt;
    public bool purchaseDef;

    void Start()
    {
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        if (!PlayerPrefs.HasKey("buyvaz"))
        {
            PlayerPrefs.SetInt("buyvaz", 0);
        }
        rubinInt = PlayerPrefs.GetInt("rubin");
        scoreInt = PlayerPrefs.GetInt("score");
        pricevaz = PlayerPrefs.GetInt("buyvaz");
    }


    void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("buyvaz", pricevaz);
        pricevaz = PlayerPrefs.GetInt("buyvaz");
        PlayerPrefs.SetInt("rubin", rubinInt);

        if (pricevaz == 1)
        {
            purchaseDef = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
        }
        if (pricevaz == 0)
        {
            purchaseDef = false;
            viborButton.SetActive(false);
            buyButton.SetActive(true);
        }
        if (purchaseDef == true)
        {
            viborButton.SetActive(true);
            buyButton.SetActive(false);
        }

    }
    public void Buyvaz()
    {
        if (rubinInt >= 30)
        {
            pricevaz = 1;
            purchaseDef = true;
            viborButton.SetActive(true);
            buyButton.SetActive(false);
            rubinInt = rubinInt - 30;
            PlayerPrefs.Save();
        }
        if (rubinInt < 30)
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
        SceneManager.LoadScene(38);
    }
    public void toBMW()
    {
        SceneManager.LoadScene(33);
    }
}
