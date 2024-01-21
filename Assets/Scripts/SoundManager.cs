using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Instructions to use SoundManager in game script
    // SFX: SoundManager.Instance.PlaySFX("Jump");
    // Start Music (start of scene): SoundManager.Instance.PlayMusic("Main Menu");
    // Stop Music (before loading next scene): SoundManager.Instance.musicSource.Stop();

    // Public Instance to access from anywhere
    public static SoundManager Instance;

    public Sound[] musicSound, sfxSounds;
    public AudioSource musicSource, sfxSource;

    // Singelton Instance 
    // - ensures there's always atleast one Instance
    // - ensures no more than one Instance in scene

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Play BGM 
    // BGM is always loop using Loop toggle in music source object
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSound, x => x.name == name);

        if (s != null)
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
        else
        {
            Debug.Log("Sound not found");
        }
    }

    // Play SFX once
    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.name == name);

        if (s != null)
        {
            sfxSource.PlayOneShot(s.clip);
        }
        else
        {
            Debug.Log("Sound not found");
        }
    }
}
