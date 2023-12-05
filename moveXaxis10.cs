using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveXaxis10 : MonoBehaviour {

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
		if (transform.position.x <= 12.05) {
			rb.velocity=new Vector3(3,0,0);
		}
		else if(transform.position.x>=14.15)
		{
			rb.velocity=new Vector3(-3,0,0);
		}
	}
}
