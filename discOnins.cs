using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class discOnins : MonoBehaviour {

	// Use this for initialization

	void Start () {
		Rigidbody2D x = this.GetComponent<Rigidbody2D> ();
		x.velocity = new Vector3 (-90, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.localPosition.x>=-280)
		{
			Destroy (this.gameObject);
			Destroy (GameObject.Find ("Image (7)"));
		}
	}
}
