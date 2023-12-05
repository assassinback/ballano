using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPause : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnPauseClick(){
		Time.timeScale = 0;
	}

	public void OnResumeClick(){
		Time.timeScale = 1;
	}
}
