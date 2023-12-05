using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveyaxis6th : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity=new Vector3(0,3,0);
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y >= -1f) {
			rb.velocity=new Vector3(0,-3,0);
		}
		else if(transform.position.y<=-3.3f)
		{
			rb.velocity=new Vector3(0,3,0);
		}
	}
}
