using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amulete : MonoBehaviour
{
    public Light stoune;
    public Transform target;
    void Start()
    {
        
    }

    void Update()
    {
        var looker = transform.position - target.position;
        float inten = Quaternion.Angle(Camera.main.transform.rotation, Quaternion.LookRotation(looker));
        stoune.intensity = inten / 180;
    }
}
