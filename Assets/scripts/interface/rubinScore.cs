using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rubinScore : MonoBehaviour {

    public Text rubinText;
    public int rubinInt;

    void Start () {
        if (!PlayerPrefs.HasKey("rubin"))
        {
            PlayerPrefs.SetInt("rubin", 0);
        }
        rubinText.text = rubinInt.ToString();
        rubinInt = PlayerPrefs.GetInt("rubin");
    }
	

	void Update () {
        rubinText.text = rubinInt.ToString();
        rubinInt = PlayerPrefs.GetInt("rubin");
    }
}
