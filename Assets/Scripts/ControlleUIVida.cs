 using UnityEngine;
using UnityEngine.UI;

public class ControlleUIVida : MonoBehaviour
{
    #region Variaveis Privadas
    private Character _personagem;
    [SerializeField] private Image _marcadorDeVida;
    #endregion

    #region Variaveis publicas

    #endregion

    #region Metodos UNITY
    private void Awake()
    {
        _personagem = DataFactory.GetPersonagem();
    }
    #endregion

    #region Metodos Proprios

    public void NotificarDano(float vidaAtual)
    {
        _marcadorDeVida.fillAmount = _personagem.VidaAtual / _personagem.Data.VidaMaxima;
    }
     
    #endregion

    


}
