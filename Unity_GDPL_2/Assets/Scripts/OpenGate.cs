using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
        if (GameObject.Find("TriggerBox (6)").GetComponent<Triggerbox7>().Collide7)
        {
            transform.Translate(new Vector3(-0.0005f, +0.0000f, +0), Space.World);

        }
    }
}
