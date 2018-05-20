using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCOllideSound : MonoBehaviour {
    public AudioSource audioSource;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
}
