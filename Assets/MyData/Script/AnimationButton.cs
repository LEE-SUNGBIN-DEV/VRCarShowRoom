using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationButton : MonoBehaviour
{
    public Animator carAnimator;
    public bool isOpen = false;

    public AudioSource doorOpenSound;
    public AudioSource doorCloseSound;

    public void OnClickButton()
    {
        doorOpenSound.mute = false;
        doorOpenSound.loop = false;
        doorOpenSound.playOnAwake = false;

        doorCloseSound.mute = false;
        doorCloseSound.loop = false;
        doorCloseSound.playOnAwake = false;

        if (isOpen == false)
        {
            doorOpenSound.Play();
            carAnimator.SetBool("isOpen", true);
            isOpen = true;
        }

        else
        {
            doorCloseSound.Play();
            carAnimator.SetBool("isOpen", false);
            isOpen = false;
        }

    }
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
