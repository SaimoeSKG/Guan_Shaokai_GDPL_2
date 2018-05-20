using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveup1 : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("TriggerBox (5)").GetComponent<triggerbox3>().collide3)
        {
            transform.Translate(new Vector3(+0, +0.001f, +0), Space.World);
        }//working code
        
        // currently has no impact

    }
    
}
