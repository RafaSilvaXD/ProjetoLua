using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    #region Variaveis privadas
    

    private ControllerCamera _camera;

    private ControllerVida _vida; 

    private CharacterController _controller;

    [SerializeField] private DataPersonagem _data;

    [SerializeField] private ControllerMovimento _movimento;
    #endregion

    #region Propriedades 

    public CharacterController Controller
    {
        get => _controller; 
    }

    public DataPersonagem Data
    {
        get => _data;
    }

    #endregion

    #region Metodos UNITY
    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _movimento = new ControllerMovimento(this);
    }

    private void Update()
    {
         
    }

    private void FixedUpdate()
    {
        _movimento.Mover(true);
    }
    #endregion

    #region Metodos Propios

    #endregion
}
