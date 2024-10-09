using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{
    public Animator Animator;

    public void UIAnimation()
    {
        Animator.SetTrigger("Start Ani");
    }
}
