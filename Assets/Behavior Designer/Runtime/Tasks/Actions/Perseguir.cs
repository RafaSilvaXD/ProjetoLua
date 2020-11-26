using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguir : Action
{
    public AbstractInimigos _inimigo;
    public SharedTransform target;

    public override void OnStart()
    {
        _inimigo.GetNavMesh().destination = target.Value.position;
    }
    public override TaskStatus OnUpdate()
    {
        if (target.Value.transform != null && Vector3.Distance(_inimigo.transform.position, target.Value.transform.position) < 5)
        {
            _inimigo.GetNavMesh().destination = target.Value.position;
            return TaskStatus.Running;
        }
        else
        {
            target = null;
            return TaskStatus.Failure;
        }
    }
}
