
public delegate void OnReceberDano(float hp); 
public class ControllerVida
{
    #region Variaveis privadas

    private Character _personagem;
    #endregion

    #region Variaveis Publicas

    #endregion

    #region Evento
     
    public  event OnReceberDano receberDano; 
    #endregion

    #region Constructor
    public ControllerVida(Character personagem)
    {
        _personagem = personagem;
        receberDano += DataFactory.GetUIVida();
    }

    ~ControllerVida()
    { 
        receberDano -= DataFactory.GetUIVida();
    }

    #endregion

    #region Metodos Propios

    public void ReceberDano(float Dano)
    {
        _personagem.VidaAtual -= Dano;
        receberDano?.Invoke(_personagem.VidaAtual);
    }
    
    #endregion
}