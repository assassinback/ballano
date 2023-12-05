using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movexaxis8th : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity=new Vector3(3,0,0);
	}
	void OnTriggerEnter2D(Collider2D col)
	{

	}
	// Update is called once per frame
	void Update () {
		if (transform.position.x <= 2.27f) {
			rb.velocity=new Vector3(3,0,0);
		}
		else if(transform.position.x>=4)
		{
			rb.velocity=new Vector3(-3,0,0);
		}
	}
}
