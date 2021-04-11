using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseNode : Node
{

    private Transform player;
    private Transform enemy;

    private float playerCloseEnoughTOChase = 2.7f;

    public ChaseNode(Transform player, Transform enemy, float playerCloseEnoughTOChase)
    {
        this.player = player;
        this.enemy = enemy;
        this.playerCloseEnoughTOChase = playerCloseEnoughTOChase;
    }

    //private float playerCloseEnoughTOAttack = 1.125f;

    public override NodeState Check()
    {

        float distanceBTWplayers = Vector3.Distance(enemy.position, player.position);

        if (playerCloseEnoughTOChase >= distanceBTWplayers)
        {

            Debug.Log("Chase the Player");
            return NodeState.running;
        }
        else
        {

            //Debug.Log("Chase the Player");
            return NodeState.success;
        }
    }
}
