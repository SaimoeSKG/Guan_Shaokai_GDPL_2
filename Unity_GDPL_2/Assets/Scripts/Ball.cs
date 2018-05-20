using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3 launchVeclocity;
    public bool BallDes;
    private Rigidbody rigidBody;
    public AudioSource audioSource;
    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = launchVeclocity;


    }
	
	// Update is called once per frame
	void Update () {
        // currenlt doing nothing
        
    }
    public void OnTriggerEnter(Collider col)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        if (col.gameObject.name == "TriggerBox (3)")
        {
            BallDes = true;
        }
    }
    
}
