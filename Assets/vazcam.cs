using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vazcam : MonoBehaviour {

    public new Camera camera;

    void Start()
    {
        camera = gameObject.GetComponent("Camera") as Camera;
    }
    void Update()
    {
        var cam = camera.transform.position;
        cam.x = PlayerPrefs.GetFloat("ObjX");
        cam.y = PlayerPrefs.GetFloat("ObjY");
        camera.transform.position = cam;
    }
}
