using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximityNode : Node
{
    private float range;
    private Transform player;
    private Transform enemy;

    public proximityNode(float range, Transform player, Transform enemy)
    {
        this.range = range;
        this.player = player;
        this.enemy = enemy;
    }

    public override NodeState Check()
    {

        float distanceBTWplayers = Vector3.Distance(enemy.position, player.position);
        return distanceBTWplayers >= range ? NodeState.success : NodeState.failure;
    }
}
