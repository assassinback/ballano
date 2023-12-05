using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscript1 : MonoBehaviour {

	// Use this for initialization
	GameObject key;
	GameObject locka;
	GameObject key1;
	GameObject locka1;
	void Start () {
		key = GameObject.Find ("key");
		locka = GameObject.Find ("lock");
		key1 = GameObject.Find ("key (1)");
		locka1 = GameObject.Find ("lock (1)");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "key") {
			Destroy (locka.gameObject);
			Destroy (key.gameObject);
		}
		if (col.gameObject.name == "key (1)") {
			Destroy (locka1.gameObject);
			Destroy (key1.gameObject);
		}
	}
}
