using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovingAnimation : MonoBehaviour
{
    private Animator anim;
    public GameObject player;

    void Start()
    {

        anim = GetComponent<Animator>();
    }

    void Update()
    {

        playermovement P = player.GetComponent<playermovement>();

        if (P.direction.magnitude >= 0.1f)
        {

            anim.SetBool("ifmoving",true);
        }
        else
        {

            anim.SetBool("ifmoving",false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            anim.SetTrigger("ifjumping");
        }
        //if (Input.GetKey("h"))
       // {

         //   anim.SetTrigger("ifpunchingRight");
      //  }
    }
}
