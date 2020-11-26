using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    private Vector3 _direcao;
    // Start is called before the first frame update
    void Start()
    {
        _direcao = ControllerGame.Instance.Personagem.transform.TransformDirection(Vector3.forward);
    }

    private void OnEnable()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _direcao * Time.deltaTime * 30;
    }
}
