using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager1 : MonoBehaviour {

    public AudioClip[] sounds;
    public AudioSource source;
    public static AudioManager1 instance;

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
        source.loop = false;
        source.playOnAwake = false;
    }

    public void PlaySound(int index)
    {
        source.clip = sounds[index];
        source.Play();
    }

}
