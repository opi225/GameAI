using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This Class is for a miner actor. They will repeatedly prospect rocks, get ore, and then bring it back to the chests.
 */

public class Miner : ActorBase
{
    public override void Start()
    {
        base.Start();
        moveSpeed = 10f;
        goal.Add(new KeyValuePair<string, object>("Ore In Chest", true));
    }

    protected override void Update()
    {
        base.Update();
    }
}
