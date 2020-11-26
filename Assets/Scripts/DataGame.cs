using UnityEngine;

[CreateAssetMenu(menuName = "Prototipo/Config")] 
public class DataGame: ScriptableObject
{
    #region Variaveis privadas

    [SerializeField] private float _modificadorGravidade;
    #endregion

    #region Propriedades

    public float ModificadorDeGracidade { get => _modificadorGravidade; }
    #endregion
}