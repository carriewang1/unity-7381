using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscenes : MonoBehaviour
{
    public bool cutscene1played = false;
    public GameObject PlayerCam;
    public GameObject cutscene1Cam;

    void Start()
    {
        PlayerCam.SetActive(true);
        cutscene1Cam.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "cutscene1" && cutscene1played == false)
        {
            cutscene1played = true;
            PlayerCam.SetActive(false);
            cutscene1Cam.SetActive(true);
            Invoke("SwitchToPlayerCam",10f);
        }
    }
    void SwitchToPlayerCam()
    {
        PlayerCam.SetActive(true);
        cutscene1Cam.SetActive(false);
    }

}
