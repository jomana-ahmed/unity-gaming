using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Static instance: only one AudioManager in the entire game
    public static AudioManager Instance;

    public AudioSource musicSource; // Background music
    public AudioSource sfxSource;   // Sound effects

    public AudioClip overworldMusic; // Background music for level 1
    public AudioClip caveMusic;      // Background music for level 2

    public AudioClip[] variousSFX;   // Array of sound effects

    void Awake()
    {
        // Make sure the entire game only has one Audio Manager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    void Start()
    {
        // Background music clip is assigned
        musicSource.clip = overworldMusic;

        musicSource.Play();
    }

    // Play a specific sound effect
    public void PlayMusicSFX(AudioClip clip)
    {
        sfxSource.clip = clip;
        sfxSource.Play();
    }

    // Play a specific soundtrack
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }

    // Play a random sound effect from an array
    public void PlayRandomSFX(params AudioClip[] clips)
    {
        // Assign incoming array to local array variable
        variousSFX = clips;

        // Randomly select a sound clip
        int index = Random.Range(0, variousSFX.Length);

        sfxSource.PlayOneShot(variousSFX[index]);
    }
}