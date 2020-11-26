using UnityEngine;

[System.Serializable]
public class ControllerCombate
{
    #region Variaveis privadas

    private Character _personagem;

    private GameObject _projetil;
    #endregion

    #region Variaveis Publicas

    #endregion

     

    #region Constructor
    public ControllerCombate(Character personagem)
    {
        _personagem = personagem; 
    } 
    #endregion

    #region Metodos Propios

    public void AtaqueADistancia()
    {
        GameObject projetil = MonoBehaviour.Instantiate(_personagem.Data.Projetil);
        projetil.transform.position = ControllerGame.Instance.Personagem.transform.position;
    }

    #endregion
}