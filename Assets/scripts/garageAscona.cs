using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class garageAscona : MonoBehaviour { // не настроен тюинг двигателя!

    public Text motorhp;
    private int HPAscona;
    private int updateHPAscona;
    private int scoreInt, rubinInt;
    public GameObject UpdButton1;
    public GameObject UpdButton2;
    public GameObject UpdButton3;
    public GameObject FinalButton;

    void Start()
    {
        if (!PlayerPrefs.HasKey("updateHPAscona"))
        {
            PlayerPrefs.SetInt("updateHPAscona", 0);
        }
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        rubinInt = PlayerPrefs.GetInt("rubin");
        HPAscona = PlayerPrefs.GetInt("HPAscona");
        updateHPAscona = PlayerPrefs.GetInt("updateHPAscona");
        scoreInt = PlayerPrefs.GetInt("score");
        updateHPAscona = 0;
        if (updateHPAscona == 0)
        {
            HPAscona = 1200;
            //UpdButton1.SetActive(true);
            motorhp.text = ("Мотор: 1.6 л, 120 л.с.");
        }
        if (updateHPAscona == 1)
        {
            HPAscona = 1350;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            motorhp.text = ("Мотор: 2.4 л, 135 л.с.");
        }
        if (updateHPAscona == 2)
        {
            HPAscona = 1480;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(true);
            FinalButton.SetActive(false);
            motorhp.text = ("Мотор: 2.8 л, 148 л.с.");
        }
        if (updateHPAscona == 3)
        {
            HPAscona = 1600;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(false);
            FinalButton.SetActive(true);
            motorhp.text = ("Мотор: 3.5 л, 160 л.с.");
        }
    }


    void Update()
    {
        PlayerPrefs.SetInt("HPAscona", HPAscona);
        HPAscona = PlayerPrefs.GetInt("HPAscona");
        PlayerPrefs.SetInt("updateHPAscona", updateHPAscona);
        updateHPAscona = PlayerPrefs.GetInt("updateHPAscona");
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("rubin", rubinInt);
    }
    public void toMaps()
    {
        SceneManager.LoadScene(25);
    }
    public void backToClass()
    {
        SceneManager.LoadScene(23);
    }
    public void UpdateMotor1()
    {
        if (scoreInt >= 250)
        {
            scoreInt = scoreInt - 200;
            motorhp.text = ("Мотор: 2.4 л, 135 л.с.");
            updateHPAscona = 1;
            HPAscona = 1350;
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
            updateHPAscona = 2;
            HPAscona = 1480;
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
            updateHPAscona = 2;
            HPAscona = 1600;
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

