using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;
    public AudioClip playerExplosion;
    public AudioClip EnemyExplosion;
    public AudioClip bulletFire;
    public AudioClip alienbuzz1;
    public AudioClip alienbuzz2;

    private AudioSource SoundEffectAudio;

  
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        AudioSource audioo = GetComponent<AudioSource>();
        SoundEffectAudio = audioo;
    }

    public void PlayOneShot(AudioClip clip)
    {
        SoundEffectAudio.PlayOneShot(clip);
    }
}
