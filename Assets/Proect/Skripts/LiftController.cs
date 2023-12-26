using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour {
    public Animator anim;
	public AudioClip clip, run;

	public void LiftOpen(bool open){
        anim.SetBool("Open", open);
	}
    public void Open()
    {
        SoundPlayer.regit.Play(clip);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LiftOpen(false);
            anim.SetBool("Run", true);
        }
    }
    public void Run()
    {
        SoundPlayer.regit.Play(run);
    }
    public void And()
    {
        LavelAnd.rid.And();
    }
}
