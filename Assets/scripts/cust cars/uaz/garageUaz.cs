using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class garageUaz : MonoBehaviour
{
    public Text motorhp, Bak;
    private int HPuaz;
    private float currentFuel;
    private int updateHPuaz1;
    private int scoreInt, rubinInt;
    public GameObject UpdButton1;
    public GameObject UpdButton2;
    public GameObject UpdButton3;
    public GameObject FinalButton;

    public void Start()
    {
        if (!PlayerPrefs.HasKey("updateHPuaz1"))
        {
            PlayerPrefs.SetInt("updateHPuaz1", 0);
        }
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        rubinInt = PlayerPrefs.GetInt("rubin");
        HPuaz = PlayerPrefs.GetInt("HPuaz");
        updateHPuaz1 = PlayerPrefs.GetInt("updateHPuaz1");
        scoreInt = PlayerPrefs.GetInt("score");
        //updateHPuaz1 = 0;
        if (updateHPuaz1 == 0)
        {
            HPuaz = 1130;
            UpdButton1.SetActive(true);
            //UpdButton2.SetActive(true);
            motorhp.text = ("Мотор: 2.2 л, 113 л.с.");
        }
        if (updateHPuaz1 == 1)
        {
            HPuaz = 1280;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            motorhp.text = ("Мотор: 2.6 л, 128 л.с.");
        }
        if (updateHPuaz1 == 2)
        {
            HPuaz = 1400;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(true);
            motorhp.text = ("Мотор: 3.0 л, 140 л.с.");
        }
        if (updateHPuaz1 == 3)
        {
            HPuaz = 1650;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(false);
            FinalButton.SetActive(true);
            motorhp.text = ("Мотор: 3.5 л, 165 л.с.");
        }
    }
    private void Update()
    {
        PlayerPrefs.SetInt("HPuaz", HPuaz);
        HPuaz = PlayerPrefs.GetInt("HPuaz");
        PlayerPrefs.SetInt("updateHPuaz1", updateHPuaz1);
        updateHPuaz1 = PlayerPrefs.GetInt("updateHPuaz1");
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("rubin", rubinInt);
    }
    public void toMapsUaz()
    {
        SceneManager.LoadScene(8);
    }
    public void backToClassUaz()
    {
        SceneManager.LoadScene(3);
    }


    public void UpdateMotor1()
    {
        if (scoreInt >= 120)
        {
            scoreInt = scoreInt - 120;
            motorhp.text = ("Мотор: 2.6 л, 128 л.с.");
            updateHPuaz1 = 1;
            HPuaz = 1280;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.1");
            
        }
        if (scoreInt < 120)
        {
            
            print("Недостаточно средств");
        }
    }
    public void UpdateMotor2()
    {
        if (scoreInt >= 200)
        {
            scoreInt = scoreInt - 200;
            motorhp.text = ("Мотор: 3.0 л, 140 л.с.");
            updateHPuaz1 = 2;
            HPuaz = 1400;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.2");
            
        }
        if (scoreInt < 200)
        {
        
            print("Недостаточно средств");
        }
    }
    public void UpdateMotor3()
    {
        if (rubinInt >= 10)
        {
          
            rubinInt = rubinInt - 10;
            motorhp.text = ("Мотор: 3.5 л, 165 л.с.");
            updateHPuaz1 = 3;
            HPuaz = 1650;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(false);
            FinalButton.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.3");
            
        }
        if (rubinInt < 10)
        {
            
            print("Недостаточно средств");
        }
    }
}