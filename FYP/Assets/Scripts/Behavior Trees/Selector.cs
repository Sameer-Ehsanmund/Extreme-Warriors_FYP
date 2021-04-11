using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Node
{

    protected List<Node> nodes = new List<Node>();

    public Selector(List<Node> nodes)
    {

        this.nodes = nodes;
    }

    public override NodeState Check()
    {

        foreach (var node in nodes)
        {

            switch (node.Check())
            {
                case NodeState.running:
                    nodeState = NodeState.success;
                    return nodeState;
                case NodeState.success:
                    nodeState = NodeState.running;
                    return nodeState;
                case NodeState.failure:
                    break;
                default:
                    break;
            }
        }

        nodeState = NodeState.failure;
        return nodeState;
    }
}
