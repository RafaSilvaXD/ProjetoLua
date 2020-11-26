using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Prototipo/Novo Inimigo")]

public class DataInimigos : ScriptableObject
{
    #region Variaveis privadas
    [SerializeField] private float _velocidadeDeMovimento;

    [SerializeField] private float _vidaMaxima;

    [SerializeField] private float _dano;

    [SerializeField] private float _velocidadeDeAtaque;

    [SerializeField] private string _nome;

    #endregion

    #region Propriedades
    public float VelocidadeDeMovimento { get => _velocidadeDeMovimento; }

    public float Dano { get => _dano; }

    public float VidaMaxima { get => _vidaMaxima; }

    public float VelocidadeDeAtaque { get => _velocidadeDeAtaque; }


    #endregion
}
