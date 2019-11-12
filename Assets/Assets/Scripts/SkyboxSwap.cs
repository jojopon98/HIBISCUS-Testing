using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxSwap : MonoBehaviour
{

    public Material initialSky, skybox1, skybox2, skybox3, skybox4, skybox5;

    // Use this for initialization
    void Start()
    {
        RenderSettings.skybox = initialSky;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Red"))
        {
            RenderSettings.skybox = skybox1;
        }
        else if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Orange"))
        {
            RenderSettings.skybox = skybox2;
        }
        else if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Yellow"))
        {
            RenderSettings.skybox = skybox3;
        }
        else if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Green"))
        {
            RenderSettings.skybox = skybox4;
        }
        else if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Blue"))
        {
            RenderSettings.skybox = skybox5;
        }
        else if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("Black"))
        {
            RenderSettings.skybox = initialSky;
        }
    }
}