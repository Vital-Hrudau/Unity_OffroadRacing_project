using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public new Camera cam;

    void Start()
    {
        cam = gameObject.GetComponent("Camera") as Camera;
    }
    void Update()
    {
        var cam = this.cam.transform.position;
        cam.x = PlayerPrefs.GetFloat("ObjX");
        cam.y = PlayerPrefs.GetFloat("ObjY");
        this.cam.transform.position = cam;
    }
}
