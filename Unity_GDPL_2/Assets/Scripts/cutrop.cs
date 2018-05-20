using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutrop : MonoBehaviour {
    public bool RopDestroyed = false;
    public float speed = -100f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Rop")
        {
            Destroy(col.gameObject);
            RopDestroyed = true;
        }
    }
}
