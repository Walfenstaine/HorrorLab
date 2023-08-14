using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerSensor : MonoBehaviour {
	public float spector = 20;
	public Transform cam;
	public bool activate;
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
			//В этой строке, вызываешь то, что должно произойти при взгляде на триггер
				activate = true;
				activ = false;

			}
		} else {
			activate = false;
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
