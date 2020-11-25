using System;
using UnityEngine;

[System.Serializable]
public class ControllerMovimento
{
    #region Variaveis privadas
    private Character _personagem;
    private Camera _cameraVisao; 
    [SerializeField] private bool _noChao;
    #endregion

    #region Variaveis Publicas
    
    #endregion

    #region Constructor
    public ControllerMovimento(Character personagem)
    {
        _personagem = personagem;
        _cameraVisao = Camera.main;
    }
    #endregion

    #region Metodos Propios
    public void Mover(bool permissao)
    {
        MovimentarPersonagem(permissao); 
        
    }

    private void MovimentarPersonagem(bool permissao)
    {
        if (!permissao) return;

        _noChao = Physics.Raycast(_personagem.transform.position, Vector3.down, _personagem.Data.DistanciarRaycastChao, _personagem.Data.Ground);

        Vector3 direcaoDeMovimento = _cameraVisao.transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"),
                                                                                           0,
                                                                                           Input.GetAxis("Vertical")));

        direcaoDeMovimento.y = 0;

        direcaoDeMovimento = direcaoDeMovimento.normalized;

        _personagem.Controller.Move(direcaoDeMovimento * _personagem.Data.VelocidadeDeMovimento * Time.deltaTime);

        RotacionarPersonagem(direcaoDeMovimento);
    }

    private void RotacionarPersonagem(Vector3 direcao)
    {
        if(direcao != Vector3.zero)
        { 
            _personagem.transform.rotation = Quaternion.LookRotation(direcao, Vector3.up);
        } 
    }
    #endregion
}