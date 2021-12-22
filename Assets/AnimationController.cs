using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator moveAnimator;
    public bool isMove = false;

    public void MoveCheck()
    {
        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {
            moveAnimator.SetBool("isMove", true);
            isMove = true;
        }

        else
        {
            moveAnimator.SetBool("isMove", false);
            isMove = false;
        }

    }
    void Start()
    {

    }


    void Update()
    {
        MoveCheck();
    }
}
