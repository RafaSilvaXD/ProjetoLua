using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriaturaPequena : AbstractInimigos
{
    public override void Ataque()
    {
        Debug.Log("Ataque");
    }

    public override void Mover()
    {
        throw new System.NotImplementedException();
    }
}
