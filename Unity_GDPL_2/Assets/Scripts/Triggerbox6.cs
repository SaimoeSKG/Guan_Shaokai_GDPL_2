using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerbox6 : MonoBehaviour {
    public bool Collide6;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Ball")
        {
            Collide6 = true;
        }
    }
}
