using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeepSound : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (Sound.instance.isSound == true)
        {
            Sound.instance.PlayBuckCollision();
        }

    }
}
