using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Disable : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] ComponentDisable;

    void Start()
    {
        if (!isLocalPlayer)
        {
            for (int i = 0; i < ComponentDisable.Length; i++)
            {
                ComponentDisable[i].enabled = false;
            }
        }
    }
}