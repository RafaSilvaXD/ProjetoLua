using BehaviorDesigner.Runtime.Tasks; 
using UnityEngine;

public class Patrulhando : Action
{
    public AbstractInimigos _inimigo;
    public Transform posicaoInicial;
    public float distanciaMaxima;
    public override void OnAwake()
    {
        base.OnAwake();
    }
    public override void OnStart()
    {
        Vector3 pos = new Vector3(posicaoInicial.position.x + Random.Range(-distanciaMaxima,distanciaMaxima),0, posicaoInicial.position.z + Random.Range(-distanciaMaxima,distanciaMaxima));
        _inimigo.SetDestine(pos); 
    }
    public override TaskStatus OnUpdate()
    {
        if (!_inimigo.GetNavMesh().isStopped)
        {
            return TaskStatus.Running;
        }
        else
        {
            return TaskStatus.Success;
        }
    }
}
