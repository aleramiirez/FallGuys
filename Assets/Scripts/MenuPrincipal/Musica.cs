using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    private static AudioSource audioSource;

    private void Awake()
    {
        if (audioSource != null)
        {
            Destroy(gameObject);
        } else
        {
            DontDestroyOnLoad(this.gameObject);
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlayMusic()
    {
        if (audioSource.isPlaying) return; audioSource.Play();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
}
