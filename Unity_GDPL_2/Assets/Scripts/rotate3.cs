using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate3 : MonoBehaviour {
    public bool Onhit = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("TriggerBox (1)").GetComponent<triggerbox2>().collide2)
        {
            transform.Rotate(Vector3.left *1000 * Time.deltaTime, Space.World);
            Onhit = true;
        }
    }
}
