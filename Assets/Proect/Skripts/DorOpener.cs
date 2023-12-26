using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;
public class DorOpener : MonoBehaviour {
    public int index;
    public AudioClip open, close;
    [SerializeField] private Language opened;
    public bool locked;
    public Animator anim;

    public void OnEventer()
    {
        Inventar.rid.index = index;
        InvPredmet.clic += UnLocked;
    }
    public void OffEventer()
    {
        InvPredmet.clic -= UnLocked;
    }
    public void UnLocked(int indexer)
    {
        if (index == indexer)
        {
            anim.SetFloat("Speed", 0.8f);
            SoundPlayer.regit.Play(open);
        }
        else
        {
            SoundPlayer.regit.Play(close);
        }
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
            Interface.rid.Inventar();
        }
    }
    public void Dan()
    {
        if (Bridge.platform.language == "ru")
        {
            SubTitres.rid.MaSage(opened.ru);
        }
        else
        {
            SubTitres.rid.MaSage(opened.en);
        }
        anim.SetFloat("Speed", 0.0f);
        Destroy(this);
    }
}
