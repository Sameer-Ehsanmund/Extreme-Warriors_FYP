using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Node
{

    protected List<Node> nodes = new List<Node>();

    public Sequence(List<Node> nodes)
    {

        this.nodes = nodes;
    }

    public override NodeState Check()
    {

        bool isanyNodeRunning = false;

        foreach (var node in nodes)
        {

            switch (node.Check())
            {
                case NodeState.running:
                    isanyNodeRunning = true;
                    break;
                case NodeState.success:
                    break;
                case NodeState.failure:
                    nodeState = NodeState.failure;
                    return nodeState;
                default:
                    break;
            }
        }

        nodeState = isanyNodeRunning ? NodeState.running : NodeState.success;
        return nodeState;
    }
}
