using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("TriggerBox").GetComponent<triggerbox1>().collide)
        {
            transform.Rotate(Vector3.forward * 30 * Time.deltaTime, Space.World);
        }

    }

    
}
