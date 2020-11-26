using System;
using UnityEngine;
public class DataFactory
{
    public static Character GetPersonagem()
    {
        return GameObject.FindObjectOfType<Character>();
    }

    public static OnReceberDano GetUIVida()
    {
        return GameObject.FindObjectOfType<ControlleUIVida>().NotificarDano;
    }

    public static OnWithoutLife GameOver()
    {
        return ControllerGame.Instance.GameOver;
    }
}