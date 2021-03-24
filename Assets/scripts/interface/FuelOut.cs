using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelOut : MonoBehaviour {

    public Text outoffuelText;
    public float speed;
    
    void Start () {
        outoffuelText = GetComponent<Text>();
        speed = 0.8f;

    }
	
	
	void Update () {
        outoffuelText.color = new Color(outoffuelText.color.r, outoffuelText.color.g, outoffuelText.color.b, Mathf.PingPong(Time.time, speed));

    }
}
