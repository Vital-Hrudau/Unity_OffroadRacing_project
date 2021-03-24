using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour {

    private Transform trans;
    public GameObject clouds;

	
	void Update () {
        clouds.GetComponent<Transform>().Translate(Vector3.right * Time.deltaTime * 0.5f);
        PlayerPrefs.Save();
       
	}
}
