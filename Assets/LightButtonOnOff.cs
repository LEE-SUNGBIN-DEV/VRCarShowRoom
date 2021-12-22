using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButtonOnOff : MonoBehaviour
{
    public GameObject carLight;
    public bool isOn = false;
    public AudioSource carLightAudio;

    public void OnClickButton()
    {
        carLightAudio.mute = false;
        carLightAudio.loop = false;
        carLightAudio.playOnAwake = false;

        carLightAudio.Play();

        if (isOn == false)
        {
            carLight.SetActive(true);
            isOn = true;
        }

        else
        {
            carLight.SetActive(false);
            isOn = false;
        }

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
