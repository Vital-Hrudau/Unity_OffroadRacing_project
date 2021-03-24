using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapsBmw : MonoBehaviour {

    public void LugaLoad()
    {
        SceneManager.LoadScene(32);
    }
    public void LoadRally()
    {
        SceneManager.LoadScene(36);
    }
    public void back()
    {
        SceneManager.LoadScene(34);
    }
}
