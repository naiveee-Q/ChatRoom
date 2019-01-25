using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ContentScripts : MonoBehaviour {

	public int time;

	// Use this for initialization
	void Start () {
		time = System.DateTime.Now.Hour;
	}

	public int UpdateTime(){
		time = System.DateTime.Now.Hour;
		return time;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
