using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;
public class DorOpener : MonoBehaviour {
    public AudioClip key, open, close;
    [SerializeField] private Language closed, keyAd, opened;
    public bool locked;
    public Animator anim;
    private bool isKay;

    public void AddKey()
    {
        if (Bridge.platform.language == "ru")
        {
            SubTitres.rid.MaSage(keyAd.ru);
        }
        else
        {
            SubTitres.rid.MaSage(keyAd.en);
        }
        isKay = true;
        SoundPlayer.regit.Play(key);
    }
    public void UnLocked()
    {
        if (Bridge.platform.language == "ru")
        {
            SubTitres.rid.MaSage(opened.ru);
        }
        else
        {
            SubTitres.rid.MaSage(opened.en);
        }
        anim.SetBool("Open", false);
        locked = false;
    }
    public void OpenDoor()
    {
        if (!locked)
        {
            anim.SetFloat("Speed", 0.8f);
            SoundPlayer.regit.Play(open);
        }
        else
        {
            if (isKay)
            {
                anim.SetBool("Open", true);
            }
            else
            {
                SoundPlayer.regit.Play(close);
                if (Bridge.platform.language == "ru")
                {
                    SubTitres.rid.MaSage(closed.ru);
                }
                else
                {
                    SubTitres.rid.MaSage(closed.en);
                }
            }
        }
    }
    public void Dan()
    {
        anim.SetFloat("Speed", 0.0f);
        Destroy(this);
    }
}
