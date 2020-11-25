using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Prototipo/Data Personagem")]
public class DataPersonagem : ScriptableObject
{
    #region Variaveis privadas
    [SerializeField] private float _velocidadeDeMovimento;

    [SerializeField] private float _vidaMaxima;

    [SerializeField] private LayerMask _ground;

    [SerializeField] private float _distanciaDeDeteccao;

    [SerializeField] private float _forcaSalto;

    #endregion

    #region Propriedades
    public float VelocidadeDeMovimento { get => _velocidadeDeMovimento;}

    public float VidaMaxima { get => _vidaMaxima; }

    public LayerMask Ground { get => _ground; }

    public float DistanciarRaycastChao { get => _distanciaDeDeteccao; }

    public float ForcaPulo { get => _forcaSalto; }
    #endregion
}
