using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    public AudioClip clip;

    public void Sound()
    {
        SoundPlayer.regit.Play(clip,1);
    }
    public void CutStop()
    {
        Interface.rid.Game();
    }
}
