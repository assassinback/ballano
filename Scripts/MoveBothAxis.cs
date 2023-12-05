using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBothAxis : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity=new Vector3(3,1,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x <= 4) {
			rb.velocity=new Vector3(3,1,0);
		}
		else if(transform.position.x>=6)
		{
			rb.velocity=new Vector3(-3,-1,0);
		}
	}
}
