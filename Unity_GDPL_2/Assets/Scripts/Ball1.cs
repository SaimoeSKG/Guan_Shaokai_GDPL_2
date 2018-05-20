using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1 : MonoBehaviour {
    public Vector3 launchVeclocity;
    private Rigidbody rigidBody;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = launchVeclocity;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
