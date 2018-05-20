using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerbox3 : MonoBehaviour {
    public bool collide3;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Bllpre(Clone)")
        {
            collide3 = true;
        }
    }
}
