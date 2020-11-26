using UnityEngine;

public delegate void OnWithoutLife();
public class Character : MonoBehaviour
{
    #region Variaveis privadas
    

    private ControllerCamera _camera;

    private ControllerVida _vida; 

    private CharacterController _controller;

    private float _vidaAtual;

    [SerializeField] private DataPersonagem _data;

    [SerializeField] private ControllerMovimento _movimento;

    [SerializeField] private ControllerCombate _combate;
    #endregion

    #region Propriedades 

    public CharacterController Controller
    {
        get => _controller; 
    } 
    public float VidaAtual
    {
        get => _vidaAtual;
        set => _vidaAtual = value;
    }
    public DataPersonagem Data
    {
        get => _data;
    }

    #endregion

    #region Eventos

    public event OnWithoutLife WithOutLife;
    #endregion

    #region Metodos UNITY
    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _movimento = new ControllerMovimento(this);
        _vida = new ControllerVida(this);
        _combate = new ControllerCombate(this);
    }
    private void OnEnable()
    {
        WithOutLife += DataFactory.GameOver();
    }
    private void Start()
    {
        _vidaAtual = Data.VidaMaxima; //Criar metodo para atualizar vida;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _combate.AtaqueADistancia();
        }
    }
    private void FixedUpdate()
    {
        _movimento.Mover(true);
    }

    private void OnDisable()
    {
        WithOutLife -= DataFactory.GameOver();
    }
    #endregion

    #region Metodos Propios
    private void OnDrawGizmos()
    {
        Ray raio = new Ray(transform.position, Vector3.down);

        Gizmos.DrawSphere(raio.origin + raio.direction *0.7f, 0.4f);
    }

    public void ReceberDano(float dano)
    {
        _vida.ReceberDano(dano);
        if(_vidaAtual <= 0)
        {
            WithOutLife?.Invoke();
        }
    }
    #endregion
}
