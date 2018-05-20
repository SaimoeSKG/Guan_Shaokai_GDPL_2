using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("TriggerBox (4)").GetComponent<Triggerbox5>().collide5)
        {
            transform.Translate(new Vector3(+0, +0.0005f, +0), Space.World);
            transform.Rotate(Vector3.forward, 10f * Time.deltaTime);
        }
    }
}
