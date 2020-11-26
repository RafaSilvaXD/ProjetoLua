using System;
using UnityEngine;
public class ControllerGame: MonoBehaviour
{
    #region Variaveis Privadas

    private static ControllerGame _instance;

    private Character _personagem;

    [SerializeField] private DataGame _config;
    #endregion

    #region Variaveis publicas

    #endregion

    #region  Propriedades
    public DataGame Config { get => _config; }
    public static ControllerGame Instance { get => _instance; }

    public Character Personagem { get => _personagem; }

    #endregion

    #region Metodos UNITY
    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(_instance);
        }
        _personagem = GameObject.FindObjectOfType<Character>();
    }
    #endregion

    #region Metodos Proprios

    public void GameOver()
    {
        Debug.Log("GameOver");
    }
    #endregion


}