using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TriggerSensor : MonoBehaviour {
	public float spector = 20;
	public Transform cam;
    public UnityEvent touch;

	private bool activ;
	private float vzglyad;

	void Start(){
		cam = Camera.main.transform;
	}
	void Update(){
		if (activ) {
			var looker = transform.position - cam.position;
			vzglyad = Quaternion.Angle (cam.rotation, Quaternion.LookRotation(looker));
			if (vzglyad <= spector) {
				activ = false;
                touch.Invoke();
			}
		} 
	}
	void OnTriggerEnter(Collider oser){
		if (oser.tag == "Player") {
			activ = true;
		}
	}
	void OnTriggerExit(Collider oser){
		if (oser.tag == "Player") {
			activ = false;
		}
	}
}
