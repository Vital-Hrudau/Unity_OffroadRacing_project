using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class garagePriora : MonoBehaviour {

    public Text motorhp;
    private int HPPriora;
    private int updateHPPriora1;
    private int scoreInt, rubinInt;
    public GameObject UpdButton1;
    public GameObject UpdButton2;
    public GameObject UpdButton3;
    public GameObject FinalButton;

    void Start()
    {
        if (!PlayerPrefs.HasKey("updateHPPriora1"))
        {
            PlayerPrefs.SetInt("updateHPPriora1", 0);
        }
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        rubinInt = PlayerPrefs.GetInt("rubin");
        HPPriora = PlayerPrefs.GetInt("HPPriora");
        updateHPPriora1 = PlayerPrefs.GetInt("updateHPPriora");
        scoreInt = PlayerPrefs.GetInt("score");
        updateHPPriora1 = 0;
        if (updateHPPriora1 == 0)
        {
            HPPriora = 1200;
            //UpdButton1.SetActive(true);
            motorhp.text = ("Мотор: 1.6 л, 120 л.с.");
        }
        if (updateHPPriora1 == 1)
        {
            HPPriora = 1350;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            motorhp.text = ("Мотор: 2.4 л, 135 л.с.");
        }
        if (updateHPPriora1 == 2)
        {
            HPPriora = 1480;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(true);
            FinalButton.SetActive(false);
            motorhp.text = ("Мотор: 2.8 л, 148 л.с.");
        }
        if (updateHPPriora1 == 3)
        {
            HPPriora = 1600;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(false);
            FinalButton.SetActive(true);
            motorhp.text = ("Мотор: 3.5 л, 160 л.с.");
        }
    }


    void Update()
    {
        PlayerPrefs.SetInt("HPPriora", HPPriora);
        HPPriora = PlayerPrefs.GetInt("HPPriora");
        PlayerPrefs.SetInt("updateHPPriora", updateHPPriora1);
        updateHPPriora1 = PlayerPrefs.GetInt("updateHPPriora1");
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("rubin", rubinInt);
    }
    public void toMaps()
    {
        SceneManager.LoadScene(21);
    }
    public void backToClass()
    {
        SceneManager.LoadScene(18);
    }
    public void UpdateMotor1()
    {
        if (scoreInt >= 250)
        {
            scoreInt = scoreInt - 200;
            motorhp.text = ("Мотор: 2.4 л, 135 л.с.");
            updateHPPriora1 = 1;
            HPPriora = 1350;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.1");
        }
        if (scoreInt < 250)
        {
            print("Недостаточно средств");
        }
    }
    public void UpdateMotor2()
    {
        if (scoreInt >= 300)
        {
            scoreInt = scoreInt - 300;
            motorhp.text = ("Мотор: 2.8 л, 148 л.с.");
            updateHPPriora1 = 2;
            HPPriora = 1480;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.2");
        }
        if (scoreInt < 300)
        {
            print("Недостаточно средств");
        }

    }
    public void UpdateMotor3()
    {
        if (scoreInt >= 400)
        {
            scoreInt = scoreInt - 300;
            motorhp.text = ("Мотор: 3.5 л, 160 л.с.");
            updateHPPriora1 = 2;
            HPPriora = 1600;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(false);
            FinalButton.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.2");
        }
        if (scoreInt < 400)
        {
            print("Недостаточно средств");
        }
    }
}

