using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class classes : MonoBehaviour
{

    public int scoreInt;
    public GameObject nonmoney;
    public  int purOrd;
    public float timer;
    public GameObject BuyText, ordinary, locked;

    private void Start()
    {
        
        if (!PlayerPrefs.HasKey("purOrd"))
        {
            PlayerPrefs.SetInt("purOrd", 0);
        }
        timer = PlayerPrefs.GetFloat("timer");
        scoreInt = PlayerPrefs.GetInt("score");
        purOrd = PlayerPrefs.GetInt("purOrd");
      
    }
    private void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("purOrd", purOrd);
        purOrd = PlayerPrefs.GetInt("purOrd");
        PlayerPrefs.SetFloat("timer", timer);
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            timer = 0;
        }
        if (purOrd == 0)
        {
            BuyText.SetActive(true);
            ordinary.SetActive(false);
            locked.SetActive(true);
        }
        else BuyText.SetActive(false);
        if(purOrd == 1)
        {
            ordinary.SetActive(true);
            locked.SetActive(false);
        }

    }
    public void customcars()
    {
        SceneManager.LoadScene(2);
    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
    public void OpenOrdinary()
    {
        if (scoreInt >= 1000)
        {
            BuyText.SetActive(false);
            ordinary.SetActive(true);
            locked.SetActive(false);
            purOrd = 1;
            scoreInt = scoreInt - 1000;
            PlayerPrefs.Save();
            nonmoney.SetActive(false);
        } nonmoney.SetActive(true);
        if (purOrd == 1)
        {
            nonmoney.SetActive(false);
        }
    }
    public void LoadOrdinary()
    {
        if (purOrd == 1)
        {
            SceneManager.LoadScene(18);
        }
    }
}
