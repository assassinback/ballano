using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {

	// Use this for initialization
	GameObject key;
	GameObject locka;
	void Start () {
		key = GameObject.Find ("key");
		locka = GameObject.Find ("lock");

	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "key") {
			Destroy (locka.gameObject);
			Destroy (key.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
