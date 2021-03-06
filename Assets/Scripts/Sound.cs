﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip deathSound, hitSound, shootSound, difSound, levelSound;
    static AudioSource audioSrc;
    void Start()
    {
        deathSound = Resources.Load<AudioClip>("death");
        hitSound = Resources.Load<AudioClip>("hit");
        shootSound = Resources.Load<AudioClip>("shoot");
        difSound = Resources.Load<AudioClip>("dif");
        levelSound = Resources.Load<AudioClip>("level");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case ("death"):
                audioSrc.PlayOneShot(deathSound);
                break;
            case ("hit"):
                audioSrc.PlayOneShot(hitSound);
                break;
            case ("shoot"):
                audioSrc.PlayOneShot(shootSound);
                break;
            case ("dif"):
                audioSrc.PlayOneShot(difSound);
                break;
            case ("level"):
                audioSrc.PlayOneShot(levelSound);
                break;

        }
    }
}
