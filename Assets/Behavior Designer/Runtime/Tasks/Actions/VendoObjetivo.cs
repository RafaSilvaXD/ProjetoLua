using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VendoObjetivo : Conditional
{
    public float _distancia;
    public AbstractInimigos _inimigo; 
    public SharedTransform target;
    public override void OnAwake()
    {
        base.OnAwake();
    }
    public override void OnStart()
    {
        base.OnStart();
    }
    public override TaskStatus OnUpdate()
    {
       if(Vector3.Distance(_inimigo.transform.position,ControllerGame.Instance.Personagem.transform.position) < _distancia)
        {
            target = ControllerGame.Instance.Personagem.transform;
            return TaskStatus.Success;
        }
        else
        {
            return TaskStatus.Failure;
        }
    }
}
