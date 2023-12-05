using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript2 : MonoBehaviour {

	// Use this for initialization
	GameObject key;
	GameObject locka;
	GameObject key1;
	GameObject locka1;
	GameObject key2;
	GameObject locka2;
	GameObject key3;
	GameObject locka3;
	GameObject key4;
	GameObject locka4;
	GameObject key5;
	GameObject locka5;
	void Start () {
		key = GameObject.Find ("key");
		locka = GameObject.Find ("lock");
		key1 = GameObject.Find ("key (1)");
		locka1 = GameObject.Find ("lock (1)");
		key2 = GameObject.Find ("key (2)");
		locka2 = GameObject.Find ("lock (2)");
		key3 = GameObject.Find ("key (3)");
		locka3 = GameObject.Find ("lock (3)");
		key4 = GameObject.Find ("key (4)");
		locka4 = GameObject.Find ("lock (4)");
		key5 = GameObject.Find ("key (5)");
		locka5 = GameObject.Find ("lock (5)");
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "key") {
			Destroy (locka.gameObject);
			Destroy (key.gameObject);
		}
		if (col.gameObject.name == "key (1)") {
			Destroy (locka1.gameObject);
			Destroy (key1.gameObject);
		}
		if (col.gameObject.name == "key (2)") {
			Destroy (locka2.gameObject);
			Destroy (key2.gameObject);
		}
		if (col.gameObject.name == "key (3)") {
			Destroy (locka3.gameObject);
			Destroy (key3.gameObject);
		}
		if (col.gameObject.name == "key (4)") {
			Destroy (locka4.gameObject);
			Destroy (key4.gameObject);
		}
		if (col.gameObject.name == "key (5)") {
			Destroy (locka5.gameObject);
			Destroy (key5.gameObject);
		}

	}
}
