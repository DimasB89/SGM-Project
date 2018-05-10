using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip[] sounds;
    public AudioSource source;
    public static AudioManager instance;
    public int id;
    public bool isPlaying;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        StartCoroutine(SongStart(id));
    }

    IEnumerator SongStart(int id)
    {
        while (true)
        {
            source.clip = sounds[id];
            if (isPlaying)
            {
                source.Play();
                isPlaying = false;
            }

            yield return new WaitForSeconds(source.clip.length);
        }
    }

    public void SetSource(int id)
    {
        source.clip = sounds[id];
        isPlaying = true;
    }
}
