 using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public abstract class AbstractInimigos : MonoBehaviour
{
    #region Variaveis privadas 

    protected float _vidaAtual; 
    protected NavMeshAgent _ia;
    protected Vector3 _destine;

    [SerializeField] private DataInimigos _data;
    #endregion

    #region Variaveis Publicas

    #endregion

    #region Propriedades
    public DataInimigos Data { get => _data; }
    #endregion

    #region Metodos Unity
    private void Awake()
    {
        _ia = GetComponent<NavMeshAgent>();
    }
    #endregion

    #region Metodos Propios 
    public abstract void Ataque();
    public abstract void Mover(); 
    public virtual void ReceberDano(float Dano)
    {
        _vidaAtual -= Dano;
        if(_vidaAtual <= 0)
        {
            Dead();
        }
    }
    public virtual void Dead()
    {
        gameObject.SetActive(true);
    }  

    public void Patrulhar()
    {
        if (!_ia.SetDestination(_destine))
        {
            Debug.Log("Destino Invalido");
        }
    }
    public NavMeshAgent GetNavMesh()
    {
        return _ia;
    }
    public void SetDestine(Vector3 pos)
    {
        
        _destine = pos;
    }
    #endregion
}
