using System;
using UnityEngine;

[System.Serializable]
public class ControllerMovimento
{
    #region Variaveis privadas
    private Character _personagem;
    private Camera _cameraVisao;
    private Vector3 _velocidadeVertical;
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

        Ray raio = new Ray(_personagem.transform.position, Vector3.down);

        _noChao = Physics.SphereCast(raio, 0.4f, 0.7f, _personagem.Data.Ground);

        Vector3 direcaoDeMovimento = _cameraVisao.transform.TransformDirection(new Vector3(0,
                                                                                           0,
                                                                                           Input.GetAxis("Vertical")));
        direcaoDeMovimento += Input.GetAxis("Horizontal") * _personagem.transform.right;
        direcaoDeMovimento.y = 0;

        _personagem.Controller.Move(direcaoDeMovimento * _personagem.Data.VelocidadeDeMovimento * Time.deltaTime);



        _velocidadeVertical.y += Physics.gravity.y * Time.deltaTime * ControllerGame.Instance.Config.ModificadorDeGracidade;

        if (_noChao && _velocidadeVertical.y < 0)
        {
            _velocidadeVertical.y = 0;
        } 

        if(Input.GetKeyDown(KeyCode.Space) && _noChao)
        {
            _velocidadeVertical.y = Mathf.Sqrt(_personagem.Data.ForcaPulo * -2 * Physics.gravity.y);
        }

        _personagem.Controller.Move(_velocidadeVertical * Time.deltaTime);

        //RotacionarPersonagem(new Vector3(direcaoDeMovimento.x,0,direcaoDeMovimento.z));
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