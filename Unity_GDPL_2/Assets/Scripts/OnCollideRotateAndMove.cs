using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollideRotateAndMove : MonoBehaviour {
    public float speed = 10f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("TriggerBox (3)").GetComponent<Triggerbox4>().collide4)
        {
            transform.Translate(new Vector3(+0, +0.001f, +0), Space.World);
            transform.Rotate(Vector3.down, speed * Time.deltaTime);
        }

    }
    
}
