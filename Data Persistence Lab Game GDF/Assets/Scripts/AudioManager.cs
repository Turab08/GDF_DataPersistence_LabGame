using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource sfx;

    public static AudioManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public void PlaySFX(AudioClip clip)
    {
        sfx.pitch = Random.Range(0.9f, 1.1f);
        sfx.PlayOneShot(clip);
    }
}
