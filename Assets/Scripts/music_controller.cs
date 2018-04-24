using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;



public class music_controller : MonoBehaviour
{


    public AudioClip[] music;
    public GameObject skip;

    private AudioSource audioSource;
    private int currentTrack = 0;

    void Awake()
    {

        DontDestroyOnLoad(this.gameObject);
    }
    // Use this for initialization
    void Start()
    {
        skip = GameObject.FindGameObjectWithTag("skip");
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;

    }

    private AudioClip GetRandom()
    {
        return music[Random.Range(0, music.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = GetRandom();
            audioSource.Play();
        }


    }

    public void SkipTrack()
    {
        
        if (currentTrack > music.Length - 1)
        {
            currentTrack = 0;
        }
        else
        {
            currentTrack++;


        }
        audioSource.clip = music[currentTrack];

    }


}
