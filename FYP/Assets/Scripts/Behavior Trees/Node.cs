using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node
{

    protected NodeState nodeState;
    public NodeState ns { get { return nodeState; } }
    public abstract NodeState Check();
}

public enum NodeState
{

    running, success, failure,
}
