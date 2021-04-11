using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainUI : MonoBehaviour
{
    public Animator anim;
    public GameObject tm;

    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !anim.IsInTransition(0))
        {

            tm.SetActive(true);
        }     
    }
}
