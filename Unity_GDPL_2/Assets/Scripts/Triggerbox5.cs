using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerbox5 : MonoBehaviour {
    public bool collide5;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Ball")
        {
            collide5 = true;
        }
    }
}
