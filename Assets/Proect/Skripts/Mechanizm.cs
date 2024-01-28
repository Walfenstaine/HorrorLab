using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mechanizm : MonoBehaviour
{
public UnityEvent touch;
public int[] index;
public GameObject[] tool;
public Lamp[] lamp;
public AudioClip open, close;
public bool locked;
public Animator anim;
private int num;

public void OnEventer()
{
    InvPredmet.clic += UnLocked;
}
public void OffEventer()
{
    InvPredmet.clic -= UnLocked;
}
public void UnLocked(int indexer)
{
    for (int i = 0; i < tool.Length; i++)
    {
    if (index[i] == indexer)
    {
            Inventar.rid.index = index[i];
            tool[i].SetActive(true);
            lamp[i].Click(true);
            SoundPlayer.regit.Play(open,1);
                if (num < tool.Length-1)
                {
                    num += 1;
                }
                else
                {
                    locked = false;
                }
    }
    }
    }
public void OpenDoor()
{
    if (!locked)
    {
        anim.SetFloat("Speed", 0.8f);
    }
    else
    {
        Interface.rid.Inventar();
    }
}
public void Dan()
{
    anim.SetFloat("Speed", 0.0f);
    SoundPlayer.regit.Play(close,1);
    Destroy(this);
        touch.Invoke();
    }
}

