using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGravity : MonoBehaviour {

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "pCube9")
        {
            rigidbody.useGravity = true;
        }
    }
    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
