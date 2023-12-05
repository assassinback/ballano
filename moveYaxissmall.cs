using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveYaxissmall : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity=new Vector3(0,3,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y >= 3.5) {
			rb.velocity=new Vector3(0,-3,0);
		}
		else if(transform.position.y<=0)
		{
			rb.velocity=new Vector3(0,3,0);
		}
	}
}
