using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerbox1 : MonoBehaviour {
    public bool collide;
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
            collide = true;
            
        }
        else
        {
            collide = false;
        }
    }
    
   
}
