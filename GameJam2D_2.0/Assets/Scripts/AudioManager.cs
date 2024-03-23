using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip passos;
    public AudioClip vitoria;
    public AudioClip item;
    public AudioClip derrota;
    public AudioClip faseIniciar;

    private void Start()
    {
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);    
    }
}
