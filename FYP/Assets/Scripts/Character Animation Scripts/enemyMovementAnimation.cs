using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovementAnimation : MonoBehaviour
{
    private Animator anim;

    public GameObject enemy;
    public GameObject player;

    void Start()
    {

        anim = GetComponent<Animator>();
    }

    void Update()
    {

        enemyAIlogic enim = enemy.GetComponent<enemyAIlogic>();     //an object of the required class is made in order to access the variable
        playergettingHit enim1 = player.GetComponent<playergettingHit>();

        if (enim.ifplayercollides == true)
        {

            anim.SetBool("ifplayertriggers", true);
        }
        if (enim.ifplayercollides == false)
        {

            anim.SetBool("ifplayertriggers", false);
        }
        if (enim1.ifenemycollidesPlayer == false)
        {

            anim.SetBool("ifpunching", false);
            anim.SetBool("ifpunching2", false);
        }
        if (enim1.ifenemycollidesPlayer == true)
        {

            switch (Random.Range(0, 2))     //enemy uses different moves randomly
            {
                case (0):
                    anim.SetBool("ifpunching", true);
                    break;
                case (1):
                    anim.SetBool("ifpunching2", true);
                    break;
            }
        }
    }
}
