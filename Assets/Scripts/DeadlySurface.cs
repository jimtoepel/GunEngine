﻿using UnityEngine;
using System.Collections;

public class DeadlySurface : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
    void OnTriggerEnter(Collider other) {
    	Debug.Log ("Hit!");
	//    Destroy(other.gameObject);
    }
}
