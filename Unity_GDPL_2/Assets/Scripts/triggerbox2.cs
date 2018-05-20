using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerbox2 : MonoBehaviour {
    public bool collide2;
    public Transform Spawnpoint;
    public GameObject SpawnTarget;
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
            collide2 = true;
            Instantiate(SpawnTarget, Spawnpoint.position, Spawnpoint.rotation);
        }
        else
        {
            collide2 = false;
        }
    }
}
