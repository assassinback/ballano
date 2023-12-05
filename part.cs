using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part : MonoBehaviour {

	// Use this for initialization
	public ParticleSystem x;
	void Start () {
		x = this.GetComponent<ParticleSystem> ();
		x.enableEmission = false;
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		x.enableEmission = true;
		StartCoroutine (stopspark ());
	}
	// Update is called once per frame
	IEnumerator stopspark()
	{
		yield return new WaitForSeconds (0.5f);
		x.enableEmission = false;
	}
	void Update () {
		
	}
}
