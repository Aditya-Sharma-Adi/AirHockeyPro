using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static Sound instance;

    public AudioClip BuckCollision;
    private AudioSource audioSource;
    public bool isSound;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        isSound = true;
        audioSource=GetComponent<AudioSource>();
    }

    public void PlayBuckCollision()
    {
       audioSource.PlayOneShot(BuckCollision);
    }
}
