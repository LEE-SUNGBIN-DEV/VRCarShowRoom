using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SitButton : MonoBehaviour
{
    public Animator sitAnimator;
    public bool isSit = false;

    public void OnClickButton()
    {
        Debug.Log("Button Clicked");

        if (isSit == false)
        {
            sitAnimator.SetBool("isSit", true);
            isSit = true;
        }

        else
        {
            sitAnimator.SetBool("isSit", false);
            isSit = false;
        }

    }
    void Start()
    {

    }


    void Update()
    {

    }
}
