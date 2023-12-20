using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using InstantGamesBridge;
public class Passworder : MonoBehaviour {
    [SerializeField] private Language closed, opened;
    public AudioClip des;
    public UnityEvent pssOk;
    public int pas_Ok;
	public int password;
	public int maxKeys = 3;
	public Text displayText;

	public void Deselect(){
		password = 0;
		displayText.text = "";
        SoundPlayer.regit.Play(des);


	}
    public void Select()
    {
        if (password == pas_Ok)
        {
            pssOk.Invoke();
        }
        else
        {
            Deselect();
        }
    }
	public void Click(int i){
        if (displayText.text.Length < maxKeys)
        {
            password = 10 * password + i;
            displayText.text = "" + password;
        }
        else
        {
            Select();
        }
	}
}