using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud1 : MonoBehaviour {

    private Transform trans;
    public GameObject clouds;
    public float speedcloud;

    void Start()
    {
        speedcloud = 0.5f;

    }

    
    void Update()
    {
        clouds.GetComponent<Transform>().Translate(Vector3.left * Time.deltaTime * speedcloud);

    }
}
