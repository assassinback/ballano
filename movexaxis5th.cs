using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movexaxis5th : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity=new Vector3(3,0,0);
	}
	// Update is called once per frame
	void Update () {
		if (transform.position.x >= 10.2f) {
			rb.velocity=new Vector3(-3,0,0);
		}
		else if(transform.position.x<=8.3f)
		{
			rb.velocity=new Vector3(3,0,0);
		}
	}
}
