using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackNode : Node
{

    private Transform player;
    private Transform enemy;

    private float playerCloseEnoughTOAttack = 1.125f;

    public AttackNode(Transform player, Transform enemy, float playerCloseEnoughTOAttack)
    {
        this.player = player;
        this.enemy = enemy;
        this.playerCloseEnoughTOAttack = playerCloseEnoughTOAttack;
    }

    public override NodeState Check()
    {

        float distanceBTWplayers = Vector3.Distance(enemy.position, player.position);

        if (playerCloseEnoughTOAttack >= distanceBTWplayers)
        {

            Debug.Log("Attack the Player");
            return NodeState.running;
        }
        else
        {

            //Debug.Log("Chase the Player");
            return NodeState.success;
        }
    }
}
