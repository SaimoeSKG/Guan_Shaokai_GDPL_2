using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerbox7 : MonoBehaviour {
    public bool Collide7;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    public void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.name == "Box")
            {
                Collide7 = true;
            }
        }
}
