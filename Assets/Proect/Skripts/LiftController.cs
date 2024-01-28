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
        SoundPlayer.regit.Play(clip,1);
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
        float dis = Vector3.Distance(transform.position, Muwer.rid.transform.position);
        if (dis <= 7)
        {
            SoundPlayer.regit.Play(run, 1);
        }
       
    }
    public void And()
    {
        LavelAnd.rid.And();
    }
}
