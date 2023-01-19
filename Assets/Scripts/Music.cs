using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource asource;
    public AudioClip music;

    private void Start()
    {
        asource = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
        asource.PlayOneShot(music);
    }
}
