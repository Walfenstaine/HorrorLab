using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrimer : MonoBehaviour
{
    public Animator anim;
    public AudioClip clip;
    public float timer = 1.0f;

    public void OnScrimer()
    {
        anim.SetFloat("Speed", 1);
        SoundPlayer.regit.Play(clip, 2);
        Destroy(gameObject, timer);
    }
}
